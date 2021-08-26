using System;
using Microsoft.EntityFrameworkCore;

namespace TestTask.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SeedPerson(modelBuilder);
        }

        private void SeedPerson(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Vladimir",
                    LastName = "Rud"
                }
            );
        }
    }
}