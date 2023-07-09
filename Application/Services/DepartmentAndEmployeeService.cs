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

        public async Task<List<DepartmentDto>> GetDepartmentsHierarchyAsync(CancellationToken cancellationToken)
        {
            var domainDepartments = await _repository.GetAllDepartmentsAsync(cancellationToken);
            return _mapper.Map<List<DepartmentDto>>(domainDepartments.Where(x => x.ParentDepartmentId == null));
        }

        public async Task<EmployeeDto> UpdateEmployeeFioAsync(CancellationToken cancellationToken, Guid employeeId, string fio)
        {
            var result = await _repository.UpdateEmployeeFioAsync(cancellationToken, employeeId, fio.Trim());
            return _mapper.Map<EmployeeDto>(result);
        }
    }
}