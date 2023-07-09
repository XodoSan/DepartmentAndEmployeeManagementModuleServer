using Application.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Infrastructure.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<Employee, EmployeeDto>().ReverseMap();
            this.CreateMap<Department, DepartmentDto>()
                .ForMember(x => x.EmployeesCount, opt => opt.MapFrom(x => x.Employees.Count()));
        }
    }
}