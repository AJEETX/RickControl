using app.Model.Domain;
using app.Model.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace app.Core.Service
{
    public interface ITransactionService : IService<TransactionDTO>
    {
        Task<ServiceResult<TransactionDTO>> GetWithDetailAndProductById(int id);
        Task<ServiceResult<IEnumerable<TransactionDetailDTO>>> GetTransactionDetailByTransactionId(int transactionId);
        Task<ServiceResult<IEnumerable<TransactionDetailReportDTO>>> TransactionDetailReport(TransactionDetailReportDTO criteria);
        Task<ServiceResult<int>> TransactionDetailReportCount(TransactionDetailReportDTO criteria);
    }
}
