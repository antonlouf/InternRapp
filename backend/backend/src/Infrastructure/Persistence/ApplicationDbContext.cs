using System.Reflection;
using backend.Application.Common.Interfaces;
using backend.Domain.Entities;
using Duende.IdentityServer.EntityFramework.Options;
using MediatR;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Options;
using Department = backend.Domain.Entities.Department;

namespace backend.Infrastructure.Persistence;
public class ApplicationDbContext : DbContext,IApplicationDbContext
{
    private readonly IMediator _mediator;

    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options,
        IOptions<OperationalStoreOptions> operationalStoreOptions,
        IMediator mediator)
        : base(options)
    {
        _mediator = mediator;
    
    }
    public DbSet<Department> Departments =>Set<Department>();
    public DbSet<Location> Locations => Set<Location>();


    public DbSet<InternShip> InternShips =>Set<InternShip>();   

    public DbSet<ApplicationUser> ApplicationUsers =>Set<ApplicationUser>();

    public DbSet<Language> Languages => Set<Language>();

    public DbSet<InternShipContentTranslation> Translations=>Set<InternShipContentTranslation>();

    public DbSet<PrefaceTranslation> PrefaceTranslations => Set<PrefaceTranslation>();
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
 
        base.OnModelCreating(builder);

    }



    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {

        return await base.SaveChangesAsync(cancellationToken);
    }
}
