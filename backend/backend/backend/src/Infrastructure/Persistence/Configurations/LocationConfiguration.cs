using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Infrastructure.Persistence.Configurations;
public class LocationConfiguration : IEntityTypeConfiguration<Location>
{
    public void Configure(EntityTypeBuilder<Location> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.City).IsRequired().HasMaxLength(50);
        builder.Property(x => x.StreetName).IsRequired().HasMaxLength(100);
        builder.Property(x => x.HouseNumber).IsRequired();
        builder.Property(x => x.ZipCode).IsRequired().HasMaxLength(8);



    }
}
