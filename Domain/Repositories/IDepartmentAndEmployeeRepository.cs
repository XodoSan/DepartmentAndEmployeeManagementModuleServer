using Domain.Entities;

namespace Domain.Repositories
{
    public interface IDepartmentAndEmployeeRepository
    {
        public Task<List<Employee>> GetAllEmployeesAsync(CancellationToken cancellationToken);
        public Task<List<Department>> GetAllDepartmentsAsync(CancellationToken cancellationToken);
    }
}