using DoctorManagement.Domain.Aggregates.DoctorAggregate;
using DoctorManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DoctorManagement.Infrastructure.Data.Contexts
{
    public class DoctorManagementContext : DbContext
    {
        public DoctorManagementContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<Consultant> Consultants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DoctorManagementContext).Assembly);
        }
    }
}
