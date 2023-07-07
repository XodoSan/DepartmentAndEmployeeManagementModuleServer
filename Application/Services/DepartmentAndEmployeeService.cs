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

        public async Task<List<EmployeeDto>> GetAllEmployees()
        {
            var domainEmployees = await _repository.GetAllEmployeesAsync();
            return _mapper.Map<List<EmployeeDto>>(domainEmployees);
        }

        public async Task<List<DepartmentDto>> GetAllDepartments()
        {
            var domainDepartments = await _repository.GetAllDepartmentsAsync();
            var mappedDepartments = _mapper.Map<List<DepartmentDto>>(domainDepartments);
            return mappedDepartments;
        }
    }
}