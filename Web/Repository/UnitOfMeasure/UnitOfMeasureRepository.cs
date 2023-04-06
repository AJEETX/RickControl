using app.Core.Repository;
using app.Data.Context;
using app.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace app.Repository.UnitOfMeasure
{
    public class UnitOfMeasureRepository : Repository<Data.Entity.UnitOfMeasure>, IUnitOfMeasureRepository
    {
        private RiskControlDbContext dbContext { get => _context as RiskControlDbContext; }
        public UnitOfMeasureRepository(DbContext context) : base(context)
        {
        }
    }
}
