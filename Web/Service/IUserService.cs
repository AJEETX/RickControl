using app.Model.Domain;
using app.Model.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace app.Core.Service
{
    public interface IUserService : IService<UserDTO>
    {
        Task<(ServiceResult, List<string>, string, string, string, int)> Login(string email, string password);
    }
}
