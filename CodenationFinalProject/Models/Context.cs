using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CodenationFinalProject.Models
{
    public class Context : DbContext
    {

        public DbSet<Logs> Logs { get; set; }
        public DbSet<Error> Error { get; set; }
        public DbSet<Users> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost, 1401;Database=CodenationFinalProject;User Id=sa;Password=ReallyStrongPassword123");
        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Logs>()
                .Property(b => b.CreatedDate)
                .HasDefaultValueSql("getdate()");

            modelbuilder.Entity<Error>()
                .HasMany(b => b.Logs)
                .WithOne(b => b.Error);

            modelbuilder.Entity<Users>()
                .HasMany(b => b.Logs)
                .WithOne(b => b.Users);

        }
    }


}
