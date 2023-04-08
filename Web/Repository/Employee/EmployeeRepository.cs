using app.Core.Repository;
using app.Data.Context;
using app.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace app.Repository.Employee
{
    public class EmployeeRepository : Repository<Data.Entity.EmployeeType>, IEmployeeRepository
    {
        private RiskControlDbContext dbContext { get => _context as RiskControlDbContext; }

        public EmployeeRepository(DbContext context) : base(context)
        {
        }
    }
}
