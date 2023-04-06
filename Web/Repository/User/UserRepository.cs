using app.Core.Repository;
using app.Data.Context;
using app.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace app.Repository.User
{
    public class UserRepository : Repository<Data.Entity.User>, IUserRepository
    {
        private RiskControlDbContext dbContext { get => _context as RiskControlDbContext; }

        public UserRepository(DbContext context) : base(context)
        {
        }

        public async Task<bool> EmailValidationCreateUser(string email)
        {
            return await dbContext.User.AnyAsync(x => x.Email == email);
        }

        public async Task<bool> EmailValidationUpdateUser(string email, int Id)
        {
            return await dbContext.User.AnyAsync(x => x.Email == email && x.Id != Id);
        }
        public async Task<bool> Login(string email, string password)
        {
            return await dbContext.User.AnyAsync(x => x.Email == email && x.Password == password);
        }
    }
}
