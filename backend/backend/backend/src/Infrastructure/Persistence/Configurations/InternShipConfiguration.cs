using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Infrastructure.Persistence.Configurations;
public class InternShipConfiguration : IEntityTypeConfiguration<InternShip>
{
    public void Configure(EntityTypeBuilder<InternShip> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x=>x.RequiredTrainingType).IsRequired();
        builder.HasIndex(x => new {x.SchoolYear});

        builder.Property(x=>x.SchoolYear).IsRequired();
        builder.Property(x=>x.Comments).HasMaxLength(100);
        builder.HasOne(x => x.Unit);
        builder.HasOne(x => x.SubDepartment);
        builder.Property(x=>x.Title).IsRequired().HasMaxLength(50);
    }
}
