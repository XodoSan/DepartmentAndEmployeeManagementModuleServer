using Application.DTOs;
using AutoMapper;
using Domain.Repositories;

namespace Application.Services
{
    public class DepartmentAndEmployeeService
    {
        private readonly IDepartmentAndEmployeeRepository _repository;
        private readonly IMapper _mapper;

        public DepartmentAndEmployeeService(IMapper mapper, IDepartmentAndEmployeeRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<List<EmployeeDto>> GetAllEmployees(CancellationToken cancellationToken)
        {
            var domainEmployees = await _repository.GetAllEmployeesAsync(cancellationToken);
            return _mapper.Map<List<EmployeeDto>>(domainEmployees);
        }

        public async Task<List<DepartmentDto>> GetDepartmentsHierarchy(CancellationToken cancellationToken)
        {
            var domainDepartments = await _repository.GetAllDepartmentsAsync(cancellationToken);
            var mappedDepartments = _mapper.Map<List<DepartmentDto>>(domainDepartments);
            return mappedDepartments;
        }
    }
}