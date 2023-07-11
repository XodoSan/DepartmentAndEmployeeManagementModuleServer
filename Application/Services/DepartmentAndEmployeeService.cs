using Application.DTOs;
using AutoMapper;
using Domain.Repositories;
using Infrastructure.Exceptions;

namespace Application.Services
{
    public class DepartmentAndEmployeeService
    {
        private static readonly char[] specialSimbols = new char[] { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '|', '/' };
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
            if (!IsFioValid(fio))
            {
                throw new InvalidEmployeeNameException(fio);
            }

            var result = await _repository.UpdateEmployeeFioAsync(cancellationToken, employeeId, fio.Trim());
            return _mapper.Map<EmployeeDto>(result);
        }

        /// <summary>
        /// Валидация ФИО сотрудника
        /// </summary>
        /// <param name="fio"></param>
        /// <returns></returns>
        private bool IsFioValid(string fio)
        {
            fio = fio.Trim();
            //Проверка, есть ли фамилия имя и отчество и на отсутствие спец-символов
            if (fio.Split(' ').Length != 3 || fio.Intersect(specialSimbols).Count() > 0)
            {
                return false;
            }

            return true;
        }
    }
}