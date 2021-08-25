using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace TestTask.Models
{
    public class ApplicationContext : DbContext
    {
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

        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }
    }
}
