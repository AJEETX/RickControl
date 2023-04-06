using app.Model.Domain;
using app.Model.Service;
using System.Threading.Tasks;

namespace app.Core.Service
{
    public interface IUserService : IService<UserDTO>
    {
        Task<ServiceResult> Login(string email, string password);
    }
}
