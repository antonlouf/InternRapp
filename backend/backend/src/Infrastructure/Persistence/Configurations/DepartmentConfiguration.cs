﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace backend.Infrastructure.Persistence.Configurations;
public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name)
                                     .HasMaxLength(100)
                                     .IsRequired();
        builder.HasIndex(x => x.Name);

        builder.Property(x => x.ManagerEmails).UsePropertyAccessMode(PropertyAccessMode.PreferProperty).HasConversion(v => string.Join(',', v), x => x.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList());
        builder.HasMany(x => x.PrefaceTranslations).WithOne(x => x.Unit).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(x => x.Internships).WithOne(x => x.Unit).OnDelete(DeleteBehavior.Cascade);

        builder.HasData(new List<Department>()
        {
            new(){Id=1,ManagerEmails=new List<string>{"recep@inetum-realdolmen.world" },Name="Java"
        } 
        });

    }
}