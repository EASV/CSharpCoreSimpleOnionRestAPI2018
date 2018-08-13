using Cust.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace Cust.Infrastructure.Data
{
    public class CustomerAppDBContext : DbContext
    {
        public CustomerAppDBContext(DbContextOptions<CustomerAppDBContext> options)
            : base(options) {}

        public DbSet<Customer> Customers { get; set; }
    }

}
