using System.Globalization;
using backend.Application;
using backend.Application.Common.Exceptions;
using backend.Infrastructure.Persistence.ConfigOptions;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using WebUI.ExceptionFilters;
using static System.Runtime.InteropServices.JavaScript.JSType;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddApplicationServices();

builder.Services.AddWebUIServices();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<GlobalExceptionFilter>();
builder.Services.AddControllers(opt =>
{
    opt.Filters.Add(new GlobalExceptionFilter());
});
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "cors",
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:4200"
                                              ).AllowCredentials().AllowAnyMethod().AllowAnyHeader();
                      });
});

//builder.Services.Configure<DatabaseConfigOption>(builder.Configuration.GetSection("ConnectionStrings"));
var dbConfig = new DatabaseConfigOption();
builder.Configuration.GetSection("ConnectionStrings").Bind(dbConfig);
builder.Services.AddInfrastructureServices(dbConfig);

builder.Services.AddLocalization(opt =>
{
    opt.ResourcesPath = "Resources";
});
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    List<CultureInfo> supportedCultures = new List<CultureInfo>
        {
            new CultureInfo("nl-NL"),
            new CultureInfo("fr-FR"),
            new CultureInfo("en-GB")
        };

    options.DefaultRequestCulture = new RequestCulture("nl-NL");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();

}
else
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHealthChecks("/health");
app.UseHttpsRedirection();

app.Use(async (context, next) =>
{
    try
    {
        await next();
    }
    catch (ValidationException ex)
    {

        var errorsAsArray = ex.Errors.Values.ToArray();
        string error = "";
        var result = errorsAsArray[0].Length;
        error = errorsAsArray[0][0];
        context.Response.StatusCode = 422;
        await context.Response.WriteAsJsonAsync(error);



    }
    catch (BadHttpRequestException ex)
    {
        context.Response.StatusCode = 400;
        await context.Response.WriteAsJsonAsync("the request is not appropriate");
    }
    catch(Exception ex)
    {
         context.Response.StatusCode = 500;
        await context.Response.WriteAsJsonAsync("some error happened during processing");
    }
});
app.UseStaticFiles();

app.UseSwagger();
app.UseSwaggerUI();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});
app.UseRequestLocalization();
app.UseRouting();
app.UseCors("cors");
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}/{id?}");



app.Run();