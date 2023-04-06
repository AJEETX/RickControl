using app.Core.Repository;
using app.Data.Context;
using app.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace app.Repository.Category
{
    public class ClaimStatusRepository : Repository<Data.Entity.CaseStatus>, IClaimStatusRepository
    {
        private RiskControlDbContext dbContext { get => _context as RiskControlDbContext; }

        public ClaimStatusRepository(DbContext context) : base(context)
        {
        }
    }
}
