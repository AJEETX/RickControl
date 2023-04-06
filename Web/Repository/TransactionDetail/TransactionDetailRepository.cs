using app.Core.Repository;
using app.Data.Context;
using app.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Repository.TransactionDetail
{
    public class TransactionDetailRepository : Repository<Data.Entity.TransactionDetail>, ITransactionDetailRepository
    {
        private RiskControlDbContext dbContext { get => _context as RiskControlDbContext; }
        public TransactionDetailRepository(DbContext context) : base(context)
        {
        }

        public void DeleteAllRecordByTransaction(ICollection<Data.Entity.TransactionDetail> transactionDetails)
        {
            dbContext.RemoveRange(transactionDetails);
        }

        public async Task<IEnumerable<Data.Entity.TransactionDetail>> GetByTransactionId(int transactionId)
        {
            return await dbContext.TransactionDetail.Include(x => x.Product).ThenInclude(x=> x.UnitOfMeasure).Where(x => x.TransactionId == transactionId).ToListAsync();
        }
    }
}
