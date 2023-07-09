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
            return await _dbContext.Employees
                .OrderBy(x => x.FIO)
                .ToListAsync(cancellationToken);
        }

        public async Task<List<Department>> GetAllDepartmentsAsync(CancellationToken cancellationToken)
        {
            return await _dbContext.Departments
                .Include(x => x.Employees)
                .Include(x => x.ChildDepartments)
                .ToListAsync(cancellationToken);
        }

        public async Task<Employee> UpdateEmployeeFioAsync(CancellationToken cancellationToken, Guid employeeId, string newFio)
        {
            var domainEmployee = _dbContext.Employees.First(x => x.Id == employeeId);
            domainEmployee.FIO = newFio;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return domainEmployee;
        }
    }
}