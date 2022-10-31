using Sales.Data;
using Sales.Models;

namespace Sales.Services
{
    public class SeedingService
    {
        private SalesContext _context;

        public SeedingService(SalesContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Product.Any())
            {
                return;
            }

           // Product p1 = new Product("")
        }
    }
}
