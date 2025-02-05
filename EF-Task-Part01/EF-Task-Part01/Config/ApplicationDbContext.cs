using EF_Task_Part01.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task_Part01.Config
{
    public class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=localhost;Database=test;User=root;";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(b => b.Id)
             .UseMySqlIdentityColumn() // Enable auto-increment
             .HasAnnotation("MySql:AutoIncrementStart", 10); // Start at 10
            });

        }


        public DbSet<Product> Products { get; set; }
    }
}
