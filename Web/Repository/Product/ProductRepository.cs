using app.Core.Repository;
using app.Data.Context;
using app.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Repository.Product
{
    public class ProductRepository : Repository<Data.Entity.Product>, IProductRepository
    {
        private RiskControlDbContext dbContext { get => _context as RiskControlDbContext; }

        public ProductRepository(DbContext context) : base(context)
        {
        }

        public async Task DeleteProductImage(int id)
        {
            Data.Entity.Product product = await dbContext.Product.FirstOrDefaultAsync(x => x.Id == id);

            if (product != null)
            {
                product.Image = null;
                dbContext.Entry(product).Property(f => f.Image).IsModified = true;
            }
        }

        public async Task<IEnumerable<Data.Entity.Product>> GetProductsByBarcodeAndName(string term)
        {
            return await dbContext.Product.Where(x => x.ProductName.Contains(term) || x.Barcode.Contains(term)).AsNoTracking().ToListAsync();
        }
    }
}
