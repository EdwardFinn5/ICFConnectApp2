using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
        // public DbSet<College> Colleges { get; set; }
        // public DbSet<EmpType> EmpTypes { get; set; }
        // public DbSet<HomeCity> HomeCities { get; set; }
        // public DbSet<Major> Majors { get; set; }
        // public DbSet<Photo> Photos { get; set; }
        // public DbSet<Position> Positions { get; set; }

    }
}