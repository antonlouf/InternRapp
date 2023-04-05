using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Infrastructure.Persistence.Configurations;
public class InternShipContentTranslationConfiguration : IEntityTypeConfiguration<InternShipContentTranslation>
{
    public void Configure(EntityTypeBuilder<InternShipContentTranslation> builder)
    {
        builder.HasKey(x=>x.Id);
        builder.Property(x => x.TitleContent).IsRequired().HasMaxLength(40);
        builder.Property(x => x.Description).IsRequired().HasMaxLength(350);
        builder.Property(x => x.KnowledgeToDevelop).IsRequired().HasMaxLength(250);
        builder.Property(x => x.NeededKnowledge).IsRequired().HasMaxLength(250);
        builder.Property(x => x.Location).IsRequired().HasMaxLength(250);
        builder.Property(x => x.Comment).IsRequired().HasMaxLength(250);
        builder.Property(x => x.Content).IsRequired().HasMaxLength(250);
        builder.HasOne(x => x.InternShip);
        builder.HasOne(x => x.Language);


    }
}
