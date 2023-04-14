using app.Core.Repository;
using app.Data.Context;
using app.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace app.Repository.Role
{
    public class RoleRepository : Repository<Data.Entity.Role>, IRoleRepository
    {
        private RiskControlDbContext dbContext { get => _context as RiskControlDbContext; }

        public RoleRepository(DbContext context) : base(context)
        {
        }
    }
}
