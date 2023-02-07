using System.Reflection;
using backend.Infrastructure.Persistence;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddApplicationServices();

//builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddWebUIServices();


builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Employee API",
        Version = "v1",
        Description = "An API to perform Employee operations",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "John Walkner",
            Email = "John.Walkner@gmail.com",
            Url = new Uri("https://twitter.com/jwalkner"),
        },
        License = new OpenApiLicense
        {
            Name = "Employee API LICX",
            Url = new Uri("https://example.com/license"),
        }
    });
    // Set the comments path for the Swagger JSON and UI.
   
});
builder.Services.AddControllers();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    });
    // Initialise and seed database

}
else
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHealthChecks("/health");
app.UseHttpsRedirection();
app.UseStaticFiles();

//app.UseSwaggerUi3(settings =>
//{
//    settings.Path = "/api";
//    settings.DocumentPath = "/api/specification.json";
//});

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();





app.Run();
