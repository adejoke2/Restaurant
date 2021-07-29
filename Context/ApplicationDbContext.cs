using Microsoft.EntityFrameworkCore;
using BeebarhRestaurant.Models;

namespace BeebarhRestaurant.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Category { get; set; }

        public DbSet<Product> Product { get; set; }

        public DbSet<Role> Role { get; set; }

        public DbSet<Admin> Admin { get; set; }

        public DbSet<Manager> Manager { get; set; }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<User> User { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().HasKey(a => a.userId);

            modelBuilder.Entity<Customer>().HasKey(a => a.userId);

            modelBuilder.Entity<Manager>().HasKey(a => a.userId);
        }
    }

    


}
