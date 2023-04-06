using app.Model.Domain;
using app.Model.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace app.Core.Service
{
    public interface IStoreStockService : IService<StoreStockDTO>
    {
        Task<ServiceResult<IEnumerable<StoreStockDTO>>> StoreStockReport(StoreStockDTO criteria);
    }
}
