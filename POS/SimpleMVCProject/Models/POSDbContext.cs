using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SimpleMVCProject.Models
{
    public class POSDbContext : DbContext
    {
        public POSDbContext() : base("name=MainConnection")
        {
            Database.SetInitializer<POSDbContext>(null);
        }
        public DbSet<StudentModel> Students { get; set; }
        public DbSet<CityModel> Cities { get; set; }
        public DbSet<TownshipModel> Townships { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<StudentModel>().ToTable("Student");
            modelBuilder.Entity<CityModel>().ToTable("City");
            modelBuilder.Entity<TownshipModel>().ToTable("Township");
        }
    }
}