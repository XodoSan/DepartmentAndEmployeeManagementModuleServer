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
        public ICollection<Department>? ChildDepartments { get; set; }

        /// <summary>
        /// Подразделение-родитель
        /// </summary>
        public Department? ParentDepartment { get; set; }

        /// <summary>
        /// Id подразделения-родителя
        /// </summary>
        public Guid? ParentDepartmentId { get; set; }

        /// <summary>
        /// Сотрудники данного подразделения
        /// </summary>
        public ICollection<Employee>? Employees { get; set; }
    }
}