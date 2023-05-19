using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.AccessControl;
using backend.Application.Common.Interfaces;
using backend.Domain.BaseDefinitions;
using backend.Domain.Entities;
using Duende.IdentityServer.EntityFramework.Options;
using MediatR;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Options;
using Department = backend.Domain.Entities.Department;

namespace backend.Infrastructure.Persistence;
public class ApplicationDbContext : DbContext,IApplicationDbContext
{
    private readonly IMediator _mediator;

    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options,
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

        //foreach (var entityType in builder.Model.GetEntityTypes())
        //{
        //    if (typeof(ISoftDeletable).IsAssignableFrom(entityType.ClrType))
        //    {
        //        entityType.AddProperty("IsDeleted", typeof(bool));

        //    }
        //}
        foreach (var entityType in builder.Model.GetEntityTypes())
        {
            //If the actual entity is an auditable type. 
            if (typeof(ISoftDeletable).IsAssignableFrom(entityType.ClrType))
            {
               entityType.AddProperty("IsDeleted", typeof(bool));

                // 2. Create the query filter
                var parameter = Expression.Parameter(entityType.ClrType);

                // EF.Property<bool>(post, "IsDeleted")
                var propertyMethodInfo = typeof(EF).GetMethod("Property").MakeGenericMethod(typeof(bool));
                var isDeletedProperty = Expression.Call(propertyMethodInfo, parameter, Expression.Constant("IsDeleted"));

                // EF.Property<bool>(post, "IsDeleted") == false
                BinaryExpression compareExpression = Expression.MakeBinary(ExpressionType.Equal, isDeletedProperty, Expression.Constant(false));

                // post => EF.Property<bool>(post, "IsDeleted") == false
                var lambda = Expression.Lambda(compareExpression, parameter);

                builder.Entity(entityType.ClrType).HasQueryFilter(lambda);


            }
        }
        base.OnModelCreating(builder);

    }



    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var markedAsDeleted = ChangeTracker.Entries().Where(x => x.State == EntityState.Deleted);

        foreach (var item in markedAsDeleted)
        {
            if (item.Entity is ISoftDeletable entity)
            {
                // Set the entity to unchanged (if we mark the whole entity as Modified, every field gets sent to Db as an update)
                item.State = EntityState.Unchanged;
                // Only update the IsDeleted flag - only this will get sent to the Db
                item.Property("IsDeleted").CurrentValue = true;
            }
        }
        return await base.SaveChangesAsync(cancellationToken);
    }
}
