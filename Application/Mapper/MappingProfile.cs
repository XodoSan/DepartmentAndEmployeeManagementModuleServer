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
                .ForMember(x => x.ChildDepartments, opt => opt.MapFrom(x => x.ParentReferences));
            this.CreateMap<ReferenceDepartment, DepartmentDto>()
                .ForMember(x => x.Name, opt => opt.MapFrom(x => x.Department.Name))//map from child department in the reference
                .ForMember(x => x.Id, opt => opt.MapFrom(x => x.DepartmentId));
        }
    }
}