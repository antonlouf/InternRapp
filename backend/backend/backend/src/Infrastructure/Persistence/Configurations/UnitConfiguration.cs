using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace backend.Infrastructure.Persistence.Configurations;
public class UnitConfiguration : IEntityTypeConfiguration<Unit>
{
    public void Configure(EntityTypeBuilder<Unit> builder)
    {
       builder.HasKey(x => x.Id);
       builder.Property(x => x.Name)
                                    .HasMaxLength(100)
                                    .IsRequired();
        builder.HasIndex(x => x.Name);

        builder.HasOne(x => x.Supervisor);
    }
}
