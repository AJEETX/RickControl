using app.Core.Repository;
using app.Data.Context;
using app.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace app.Repository.Transaction
{
    public class TransactionRepository : Repository<Data.Entity.Transaction>, ITransactionRepository
    {
        private RiskControlDbContext dbContext { get => _context as RiskControlDbContext; }
        public TransactionRepository(DbContext context) : base(context)
        {
        }
        public async Task<Data.Entity.Transaction> GetWithDetailById(int id)
        {
            return await dbContext.Transaction.Include(x => x.TransactionDetail).FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<Data.Entity.Transaction> GetWithDetailAndProductById(int id)
        {
            return await dbContext.Transaction.Include(x => x.TransactionDetail).ThenInclude(x=> x.Product).FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
