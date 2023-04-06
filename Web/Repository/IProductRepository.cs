using System.Collections.Generic;
using System.Threading.Tasks;

namespace app.Core.Repository
{
    public interface IProductRepository : IRepository<Data.Entity.Product>
    {
        Task DeleteProductImage(int id);
        Task<IEnumerable<Data.Entity.Product>> GetProductsByBarcodeAndName(string term);
    }
}
