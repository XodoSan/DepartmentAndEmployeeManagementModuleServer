namespace Domain.Entities
{
    /// <summary>
    /// Подразделение
    /// </summary>
    public class Department
    {
        /// <summary>
        /// Id подразделения
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Название подразделения
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Подразделения-дети
        /// </summary>
        public ICollection<ReferenceDepartment>? ChildDepartments { get; set; }
        /// <summary>
        /// Подразделения-родители
        /// </summary>
        public ICollection<ReferenceDepartment>? Departments { get; set; }

        /// <summary>
        /// Сотрудники данного подразделения
        /// </summary>
        public ICollection<Employee>? Employees { get; set; }
    }
}