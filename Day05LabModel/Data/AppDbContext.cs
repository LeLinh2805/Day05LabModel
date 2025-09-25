using Day05LabModel.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Day05LabModel.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
