using System.Threading.Tasks;

namespace app.Core.Repository
{
    public interface IStoreStockRepository : IRepository<Data.Entity.StoreStock>
    {
        Task RemoveByStoreAndProductId(int productId, int storeId);
        Task<Data.Entity.StoreStock> GetByStoreAndProductId(int productId, int storeId);
    }
}
