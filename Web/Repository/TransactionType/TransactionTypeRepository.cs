using app.Core.Repository;
using app.Data.Context;
using app.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace app.Repository.TransactionType
{
    public class TransactionTypeRepository : Repository<Data.Entity.TransactionType>, ITransactionTypeRepository
    {
        private RiskControlDbContext dbContext { get => _context as RiskControlDbContext; }
        public TransactionTypeRepository(DbContext context) : base(context)
        {
        }
    }
}
