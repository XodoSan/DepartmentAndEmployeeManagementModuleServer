using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class DepartmentAndEmployeeRepository : IDepartmentAndEmployeeRepository
    {
        private readonly AppDBContext _dbContext;

        public DepartmentAndEmployeeRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Employee>> GetAllEmployeesAsync(CancellationToken cancellationToken)
        {
            return await _dbContext
                .Employees
                .ToListAsync(cancellationToken);
        }

        public async Task<List<Department>> GetAllDepartmentsAsync(CancellationToken cancellationToken)
        {
            return await _dbContext
                .Departments
                .Include(x => x.Employees)
                .Include(x => x.ParentReferences)
                .ThenInclude(x => x.Department)
                .Include(x => x.ChildReferences)
                .ThenInclude(x => x.Department)
                .Where(x => x.ParentReferences.Any(x => x.Department != null) || (x.ParentReferences.Count() == 0 && x.ChildReferences.Count() == 0))
                .ToListAsync(cancellationToken);
        }
    }
}