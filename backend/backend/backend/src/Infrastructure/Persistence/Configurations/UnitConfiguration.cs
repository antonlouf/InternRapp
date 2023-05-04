using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace backend.Infrastructure.Persistence.Configurations;
public class UnitConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
       builder.HasKey(x => x.Id);
       builder.Property(x => x.Name)
                                    .HasMaxLength(100)
                                    .IsRequired();
        builder.HasIndex(x => x.Name);
        builder.HasMany(dep => dep.InternShips).WithOne(intrshp => intrshp.Unit).HasForeignKey(intrshp=> intrshp.UnitId).OnDelete(DeleteBehavior.Cascade); //has foreign key van Internships.id
        builder.Property(x=>x.ManagerEmails).UsePropertyAccessMode(PropertyAccessMode.PreferProperty).HasConversion(v=>string.Join(',',v),x=>x.Split(',',StringSplitOptions.RemoveEmptyEntries).ToList());
        
    }
}
