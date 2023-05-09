using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Hosting;

namespace backend.Infrastructure.Persistence.Configurations;
public class InternShipConfiguration : IEntityTypeConfiguration<InternShip>
{
    public void Configure(EntityTypeBuilder<InternShip> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.RequiredTrainingType).IsRequired();
        builder.HasIndex(x => new { x.SchoolYear });
        builder.Property(x => x.SchoolYear).IsRequired();
        builder.Property(x => x.CurrentCountOfStudents).HasConversion(v => (byte)v,
            v => v)
            .IsRequired();
        //builder.HasMany(x => x.Locations).WithMany();
        builder.Property(x => x.MaxStudents).HasConversion(v => (byte)v,
            v => v).IsRequired();
        builder.HasMany(x => x.Translations).WithOne(x => x.InternShip).OnDelete(DeleteBehavior.Cascade);

    }
}
