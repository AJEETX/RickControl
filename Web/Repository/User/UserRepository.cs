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

        public async Task<Data.Entity.User> GetUserWithRoles(int id)
        {
            return await dbContext.User.Include(x => x.Roles).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateUserWithRoles(Data.Entity.User user)
        {
            dbContext.User.Attach(user);
            var entry = dbContext.Entry(user);
            entry.State = EntityState.Modified;
            entry.Property(p => p.Roles).IsModified = true;
            await Task.Delay(1);
         }
    }
}
