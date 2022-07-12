using DoctorManagement.Domain.Aggregates.DoctorAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoctorManagement.Infrastructure.Data.Config
{
    class ConsultantEntityTypeConfig : IEntityTypeConfiguration<Consultant>
    {
        public void Configure(EntityTypeBuilder<Consultant> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Problem).HasMaxLength(30).IsRequired(true);
            builder.Property(p => p.Treatment).HasMaxLength(30).IsRequired(true);
            builder.Property(p => p.Prescription).HasMaxLength(30).IsRequired(true);
            builder.Property(p => p.Prescription).HasMaxLength(30).IsRequired(true);
        }
    }
}
