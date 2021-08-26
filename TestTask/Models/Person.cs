using System;
using System.ComponentModel.DataAnnotations;
using TestTask.Data;

namespace TestTask.Models
{
    public class Person : IEntity
    {
        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string LastName { get; set; }

        public Guid Id { get; set; }
    }
}