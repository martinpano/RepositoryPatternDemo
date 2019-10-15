using DomainModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess
{
    public class RepositoryPatternDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=RepositoryPatternDB;User Id=martin; Password=123123");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>().HasData(
                new Employee()
                {
                    Id = 1,
                    FirstName = "Martin",
                    LastName = "Panovski",
                    Email = "martinp@iborn.net",
                    City = "Skopje"
                },
                new Employee()
                {
                    Id = 2,
                    FirstName = "Petre",
                    LastName = "Petrevski",
                    Email = "petrep@iborn.net",
                    City = "Skopje"
                },
                new Employee()
                {
                    Id = 3,
                    FirstName = "Mite",
                    LastName = "Mitevski",
                    Email = "martinp@iborn.net",
                    City = "Ohrid"
                },
                new Employee()
                {
                    Id = 4,
                    FirstName = "Jovan",
                    LastName = "Jovanovski",
                    Email = "jovanj@iborn.net",
                    City = "Strumica"
                }
                );
        }
    }
}
