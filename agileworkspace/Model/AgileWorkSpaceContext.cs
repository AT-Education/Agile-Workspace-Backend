using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace agileworkspace.Model
{
    public class AgileWorkSpaceContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Seat> Seats { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=tcp:agile-workspace.database.windows.net,1433;database=agile-workspace;user=agileworkspace;password=Glsworkspace@");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Seat>(entity =>
            //{
            //    entity.HasKey(e => e.Id);
            //    entity.Property(e => e.Name).IsRequired();
            //});

            //modelBuilder.Entity<Employee>(entity =>
            //{
            //    entity.HasKey(e => e.Id);
            //    entity.Property(e => e.Name).IsRequired();
            //    entity.HasOne(e => e.Seat).WithOne(e => e.Employee); 
            //});
        }
    }
}
