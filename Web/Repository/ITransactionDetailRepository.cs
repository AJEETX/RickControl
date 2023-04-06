using System.Collections.Generic;
using System.Threading.Tasks;

namespace app.Core.Repository
{
    public interface ITransactionDetailRepository : IRepository<Data.Entity.TransactionDetail>
    {
        void DeleteAllRecordByTransaction(ICollection<app.Data.Entity.TransactionDetail> transactionDetails);
        Task<IEnumerable<Data.Entity.TransactionDetail>> GetByTransactionId(int transactionId);
    }
}
