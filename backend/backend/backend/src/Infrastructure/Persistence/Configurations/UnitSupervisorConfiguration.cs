﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Infrastructure.Persistence.Configurations;
public class UnitSupervisorConfiguration : IEntityTypeConfiguration<UnitSuperVisor>
{
    public void Configure(EntityTypeBuilder<UnitSuperVisor> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.EmailAdress)
                                          .HasMaxLength(50)
                                          .IsRequired();
    }
}
