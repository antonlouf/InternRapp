using backend.Domain.Entities;
using backend.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
        builder.HasMany(x => x.Locations).WithMany();
        builder.Property(x => x.MaxStudents).HasConversion(v => (byte)v,
            v => v).IsRequired();
        builder.HasMany(x => x.Translations).WithOne(x => x.InternShip).OnDelete(DeleteBehavior.Cascade);

 

        builder.HasData(new List<InternShip>()
        {
            new()
            {
             Id = 1,
             CurrentCountOfStudents = 0,
             MaxStudents = 10,
             RequiredTrainingType = TrainingType.Bachelor,
             SchoolYear = "2023-2024",
             UnitId = 1
            }
        });

    }
}
