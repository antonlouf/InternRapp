using backend.Application.Common.Interfaces;
using backend.Infrastructure.Persistence;
using backend.Infrastructure.Persistence.Repositories;
using backend.Infrastructure.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection;
public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IApplicationUserRepistory, ApplicationUserRepository>();
        services.AddScoped<IInternShipRepository, InternShipRepository>();
        services.AddScoped<ISubDepartmentRepository, SubDepartmentRepository>();
        services.AddScoped<IUnitRepository, UnitRepository>();
        services.AddScoped<IUnitSuperVisorRepository, UnitSupervisorRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        if (configuration.GetValue<bool>("UseInMemoryDatabase"))
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("default")));
        }
        else
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                    builder => builder.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
        }



        //services.AddAuthentication()
        //    .AddIdentityServerJwt();

        //services.AddAuthorization(options =>
        //    options.AddPolicy("CanPurge", policy => policy.RequireRole("Administrator")));

        return services;
    }
}
