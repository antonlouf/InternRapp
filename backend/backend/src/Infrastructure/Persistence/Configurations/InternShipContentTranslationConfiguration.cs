using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Domain.Entities;
using backend.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Infrastructure.Persistence.Configurations;
public class InternShipContentTranslationConfiguration : IEntityTypeConfiguration<InternShipContentTranslation>
{
    public void Configure(EntityTypeBuilder<InternShipContentTranslation> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.TitleContent).IsRequired().HasMaxLength(40);
        builder.Property(x => x.Description).IsRequired().HasMaxLength(1000);
        builder.Property(x => x.KnowledgeToDevelop).IsRequired().HasMaxLength(1000);
        builder.Property(x => x.NeededKnowledge).IsRequired().HasMaxLength(1000);
        builder.Property(x => x.Comment).IsRequired().HasMaxLength(1000);
    }
        
}
