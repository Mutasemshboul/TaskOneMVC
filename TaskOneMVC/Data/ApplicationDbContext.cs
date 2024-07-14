using Microsoft.EntityFrameworkCore;
using TaskOneMVC.Models;

namespace TaskOneMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
    }
}
