using Microsoft.EntityFrameworkCore;
using Customers.Entity;
namespace Customers.CustomerDbContext
{
    public class CustomerAppDbContext(DbContextOptions<CustomerAppDbContext> options) : DbContext(options)
    {
        public DbSet<Customer> Customers { get; set; }
    }
}
