using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Data
{
    public class MasterDbContext : DbContext
    {
        public MasterDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
    }
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }
}
