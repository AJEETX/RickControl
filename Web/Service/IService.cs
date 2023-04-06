using app.Model.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace app.Core.Service
{
    public interface IService<T> where T : class
    {

        Task<ServiceResult> AddAsync(T model);
        Task<ServiceResult<IEnumerable<T>>> Find(T criteria);
        Task<ServiceResult<int>> FindCount(T criteria);
        Task< ServiceResult<IEnumerable<T>>> GetAll();
        Task<ServiceResult<T>> GetById(int id);
        Task<ServiceResult> RemoveById(int id);
        Task<ServiceResult> Update(T model);
    }
}
