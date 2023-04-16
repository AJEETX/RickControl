using System.Threading.Tasks;

namespace app.Core.Repository
{
    public interface IUserRepository : IRepository<Data.Entity.User>
    {
        Task<bool> EmailValidationCreateUser(string email);
        Task<bool> EmailValidationUpdateUser(string email, int Id);
        Task<bool> Login(string email, string password);
        Task<Data.Entity.User> GetUserWithRoles(int id);
    }
}
