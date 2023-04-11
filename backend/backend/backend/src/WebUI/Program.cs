using System.Globalization;
using backend.Application;
using backend.Application.Common.Exceptions;
using Microsoft.AspNetCore.Localization;
using static System.Runtime.InteropServices.JavaScript.JSType;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddApplicationServices();

builder.Services.AddWebUIServices();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "cors",
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:4200"
                                              ).AllowCredentials().AllowAnyMethod().AllowAnyHeader();
                      });
});
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

    options.DefaultRequestCulture = new RequestCulture("en-GB");
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
    catch(Exception ex)
    {
        
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
