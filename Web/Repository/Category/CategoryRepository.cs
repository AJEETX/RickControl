using app.Core.Repository;
using app.Data.Context;
using app.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace app.Repository.Category
{
    public class CategoryRepository : Repository<Data.Entity.Category>, ICategoryRepository
    {
        private RiskControlDbContext dbContext { get => _context as RiskControlDbContext; }

        public CategoryRepository(DbContext context) : base(context)
        {
        }
    }
}
