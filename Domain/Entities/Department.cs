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
        /// Подразделения-ссылки-дети
        /// </summary>
        public ICollection<ReferenceDepartment>? ChildReferences { get; set; }

        /// <summary>
        /// Подразделения-ссылки-родители
        /// </summary>
        public ICollection<ReferenceDepartment>? ParentReferences { get; set; }

        /// <summary>
        /// Сотрудники данного подразделения
        /// </summary>
        public ICollection<Employee>? Employees { get; set; }
    }
}