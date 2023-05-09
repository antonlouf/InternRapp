using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Infrastructure.Persistence.Configurations;
public class InternShipLocationConfiguration : IEntityTypeConfiguration<InternShipLocation>
{
    public void Configure(EntityTypeBuilder<InternShipLocation> builder)
    {

        builder.HasKey(sr => new { sr.InternShipId, sr.LocationsId } );

        builder
            .HasOne<InternShip>(x => x.InternShip)
            .WithMany(y => y.InternShipLocations)
            .HasForeignKey(x => x.InternShipId);

        builder
            .HasOne<Location>(x => x.Location)
            .WithMany(y => y.InternShipLocations)
            .HasForeignKey(x => x.LocationsId);

        
        

        /*
        builder
                 .HasMany(p => p.LocationsId)
                 .WithMany()
                 .UsingEntity<Dictionary<string, object>>(
                     "InternShipLocation",
                     r => r.HasOne<Location>().WithMany().HasForeignKey("InternshShipId"),
                     l => l.HasOne<InternShip>().WithMany().HasForeignKey("Locations"),
                     je =>
                     {
                         je.HasKey("PostId", "TagId");
                         je.HasData(
                             new { PostId = 1, TagId = "general" },
                             new { PostId = 1, TagId = "informative" },
                             new { PostId = 2, TagId = "classic" },
                             new { PostId = 3, TagId = "opinion" },
                             new { PostId = 4, TagId = "opinion" },
                             new { PostId = 4, TagId = "informative" });
                     });
        */

    }
}
