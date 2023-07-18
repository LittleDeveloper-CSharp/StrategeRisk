using Microsoft.EntityFrameworkCore;
using StrategeRisk.Domain.Models;

namespace StrategeRisk.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<City> Cities { get; set; }
        
        public DbSet<Company> Companies { get; set; }
        
        public DbSet<Employee> Employees { get; set; }
        
        public DbSet<EmployeePosition> EmployeePositions { get; set; }
        
        public DbSet<History> Histories { get; set; }
        
        public DbSet<Note> Notes { get; set; }
             
        public DbSet<State> States { get; set; }
    }
}
