namespace Application.DTOs
{
    public class EmployeeDto
    {
        public Guid Id { get; set; }
        public string FIO { get; set; }
        public Guid DepartmentId { get; set; }
    }
}