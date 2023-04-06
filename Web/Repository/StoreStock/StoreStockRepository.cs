using app.Core.Repository;
using app.Data.Context;
using app.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace app.Repository.StoreStock
{
    public class StoreStockRepository : Repository<Data.Entity.StoreStock>, IStoreStockRepository
    {
        private RiskControlDbContext dbContext { get => _context as RiskControlDbContext; }
        public StoreStockRepository(DbContext context) : base(context)
        {
        }

        public async Task RemoveByStoreAndProductId(int productId, int storeId)
        {
            var entity = await dbContext.StoreStock.FirstOrDefaultAsync(x => x.StoreId == storeId && x.ProductId == productId);
            if (entity != null)
                dbContext.StoreStock.Remove(entity);
        }

        public async Task<Data.Entity.StoreStock> GetByStoreAndProductId(int productId, int storeId)
        {
            var entity = await dbContext.StoreStock.FirstOrDefaultAsync(x => x.StoreId == storeId && x.ProductId == productId);
            return entity;
        }

        
    }
}
