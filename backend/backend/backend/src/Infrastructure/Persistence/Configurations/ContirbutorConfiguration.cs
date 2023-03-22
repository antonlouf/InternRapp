using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Infrastructure.Persistence.Configurations;
public class ContirbutorConfiguration : IEntityTypeConfiguration<Contributor>
{
    public void Configure(EntityTypeBuilder<Contributor> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.TypeOfContributor).IsRequired();
        builder.HasOne(x => x.AppUser);
        builder.HasOne(x => x.Department);
}
}
