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
        builder.HasOne(x => x.Unit);
        builder.Property(x => x.CurrentCountOfStudents).IsRequired();
        builder.HasOne(x => x.Location);
        builder.Property(x=>x.MaxStudents).IsRequired();
        builder.HasMany(x => x.Translations).WithOne(x => x.InternShip);
    }
}
