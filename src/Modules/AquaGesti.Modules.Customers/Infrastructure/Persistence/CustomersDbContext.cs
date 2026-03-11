using AquaGesti.Modules.Customers.Domain.Customers;
using Microsoft.EntityFrameworkCore;

namespace AquaGesti.Modules.Customers.Infrastructure.Persistence
{
    public class CustomersDbContext : DbContext
    {
        public DbSet<Customer> Customers => Set<Customer>();

        public CustomersDbContext(DbContextOptions<CustomersDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CustomersDbContext).Assembly);
        }
    }
}
