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

        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            return await _dbContext
                .Employees
                .ToListAsync();
        }

        public async Task<List<Department>> GetAllDepartmentsAsync()
        {
            return await _dbContext
                .Departments
                .Include(x => x.Departments)
                .Include(x => x.ChildDepartments)
                .Include(x => x.Employees)
                .ToListAsync();
        }
    }
}