using System.Reflection;
using backend.Application.Common.Interfaces;
using backend.Domain.Entities;
using Duende.IdentityServer.EntityFramework.Options;
using MediatR;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Department = backend.Domain.Entities.Department;

namespace backend.Infrastructure.Persistence;
public class ApplicationDbContext : DbContext,IApplicationDbContext
{


    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options,
        IOptions<OperationalStoreOptions> operationalStoreOptions,
        IMediator mediator)
        : base(options)
    { }

    public DbSet<Department> Departments =>Set<Department>();
    public DbSet<Location> Locations => Set<Location>();


    public DbSet<InternShip> InternShips =>Set<InternShip>();   

    public DbSet<ApplicationUser> ApplicationUsers =>Set<ApplicationUser>();

    public DbSet<Language> Languages => Set<Language>();

    public DbSet<InternShipContentTranslation> Translations=>Set<InternShipContentTranslation>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(builder);
    }

    //Think about audit fields and DateTime UTC (very important this one) 
    // We are using CQRS -> read and write seperation (2 DB contexts is prolly overkill
    // for this but try to expose IQueryables here for the read flow -> with no changeTracker etc)
   

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {

        return await base.SaveChangesAsync(cancellationToken);
    }
}
