using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Infrastructure.Persistence.Configurations;
public class LanguageConfiguration : IEntityTypeConfiguration<Language>
{
    public void Configure(EntityTypeBuilder<Language> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Code).IsRequired().HasMaxLength(100);
        builder.HasIndex(x => x.Code).IsUnique();
        builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
        builder.HasMany(x => x.InternshipTranslations).WithOne(x => x.Language).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(x => x.PrefaceTranslations).WithOne(x => x.Language).OnDelete(DeleteBehavior.Cascade);

        builder.HasData(new List<Language>()
        {
            new(){Code="nl",Id=1,Name="Nederlands"},
            new(){Code="en",Id=2,Name="Engels"},
            new(){Code="fr",Id=3,Name="French"},

        });
    }
}
