using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Infrastructure.Persistence.Configurations;
public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Email).IsRequired().HasMaxLength(100);
        builder.HasAlternateKey(x => x.Email);
        builder.Property(x=>x.ObjectIdentifier).IsRequired();
        builder.HasIndex(x => x.ObjectIdentifier);
        builder.Property(x => x.Role).IsRequired();
        builder.HasOne(x => x.ManagerDepartment);

    }
}
