using Domain.Entities;

namespace Domain.Repositories
{
    public interface IDepartmentAndEmployeeRepository
    {
        public Task<List<Employee>> GetAllEmployeesAsync();
        public Task<List<Department>> GetAllDepartmentsAsync();
    }
}