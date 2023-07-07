﻿namespace Application.DTOs
{
    public class DepartmentDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<DepartmentDto> ChildDepartments { get; set; }
        public List<EmployeeDto> Employees { get; set; }
    }
}