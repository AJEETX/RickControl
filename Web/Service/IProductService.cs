using app.Model.Domain;
using app.Model.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace app.Core.Service
{
    public interface IProductService : IService<ProductDTO>
    {
        Task<ServiceResult> DeleteProductImage(int id);
        Task<ServiceResult<IEnumerable<ProductDTO>>> GetProductsByBarcodeAndName(string term);
    }
}
