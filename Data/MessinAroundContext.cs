using Microsoft.EntityFrameworkCore;
using WebAppMessinAroundEmpty.Data.Entities;

namespace WebAppMessinAroundEmpty.Data
{
    public class MessinAroundContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}
