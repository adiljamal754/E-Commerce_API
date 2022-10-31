using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sales.Models;

namespace Sales.Data
{
    public class SalesContext : DbContext
    {
        public SalesContext (DbContextOptions<SalesContext> options)
            : base(options)
        {
        }

        public DbSet<Sales.Models.Cart> Cart { get; set; } = default!;

        public DbSet<Sales.Models.Client> Client { get; set; }

        public DbSet<Sales.Models.Order> Order { get; set; }

        public DbSet<Sales.Models.OrderedItem> OrderedItem { get; set; }

        public DbSet<Sales.Models.Product> Product { get; set; }

        public DbSet<Sales.Models.User> User { get; set; }
    }
}
