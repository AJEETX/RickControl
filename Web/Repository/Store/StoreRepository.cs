using app.Core.Repository;
using app.Data.Context;
using app.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace app.Repository.Store
{
    public class StoreRepository : Repository<Data.Entity.Store>, IStoreRepository
    {
        private RiskControlDbContext dbContext { get => _context as RiskControlDbContext; }

        public StoreRepository(DbContext context) : base(context)
        {
        }
    }
}
