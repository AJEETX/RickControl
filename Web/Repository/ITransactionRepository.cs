using System.Threading.Tasks;

namespace app.Core.Repository
{
    public interface ITransactionRepository : IRepository<Data.Entity.Transaction>
    {
        Task<app.Data.Entity.Transaction> GetWithDetailById(int id);
        Task<Data.Entity.Transaction> GetWithDetailAndProductById(int id);
    }
}
    