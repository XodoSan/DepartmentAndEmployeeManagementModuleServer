namespace Application.DTOs
{
    public class DepartmentDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<DepartmentDto> ChildDepartments { get; set; }
        public Guid? ParentDepartmentId { get; set; }
        public int? EmployeesCount { get; set; }
    }
}