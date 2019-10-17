using DomainModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccess
{
    public class RepositoryPatternDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=RepositoryPatternDB;User Id=martin; Password=123123");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Company>()
                .HasMany(x => x.Employees)
                .WithOne(x => x.Company)
                .HasForeignKey(x => x.CompanyId);

            builder.Entity<Company>()
                .HasData(
                new Company()
                {
                    Id = 1,
                    Name = "Iborn"
                },
                new Company()
                {
                    Id = 2,
                    Name = "Grizli"
                }
                );

            builder.Entity<Employee>().HasData(
                new Employee()
                {
                    Id = 1,
                    FirstName = "Martin",
                    LastName = "Panovski",
                    Email = "martinp@iborn.net",
                    City = "Skopje",
                    Country = "Macedonia",
                    CompanyId = 1
                },
                new Employee()
                {
                    Id = 2,
                    FirstName = "Petre",
                    LastName = "Petrevski",
                    Email = "petrep@iborn.net",
                    City = "Skopje",
                    Country = "Macedonia",
                    CompanyId = 2
                },
                new Employee()
                {
                    Id = 3,
                    FirstName = "Mite",
                    LastName = "Mitevski",
                    Email = "martinp@iborn.net",
                    City = "Ohrid",
                    Country = "Macedonia",
                    CompanyId = 1
                },
                new Employee()
                {
                    Id = 4,
                    FirstName = "Jovan",
                    LastName = "Jovanovski",
                    Email = "jovanj@iborn.net",
                    City = "Strumica",
                    Country = "Macedonia",
                    CompanyId = 1
                }
                );
        }
    }
}
