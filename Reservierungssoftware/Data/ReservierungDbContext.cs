using Microsoft.EntityFrameworkCore;
using Reservierungssoftware.Models;

namespace Reservierungssoftware.Data
{
    public class ReservierungDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }


        public ReservierungDbContext(DbContextOptions<ReservierungDbContext> options) 
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            /*  FOREIGN KEY
             *  Ein Customer kann mehrere Orders haben
             *  Eine Bestellung hat EINEN Customer
             *  Eine Order verweist auf den Customer durch die Customer ID
            */
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Orders)
                .WithOne(o => o.Customer)
                .HasForeignKey(o => o.CustomerId);
        }
    }
}
