using Application.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Infrastructure.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<Employee, EmployeeDto>();
            this.CreateMap<Department, DepartmentDto>()
                .ForMember(x => x.ChildDepartments, opt => opt.MapFrom(x => x.Departments));
            this.CreateMap<ReferenceDepartment, DepartmentDto>()
                .ForMember(x => x.Name, opt => opt.MapFrom(x => x.Department.Name))
                .ForMember(x => x.Id, opt => opt.MapFrom(x => x.DepartmentId))
                .ForMember(x => x.Employees, opt => opt.MapFrom(x => x.Department.Employees));
        }
    }
}