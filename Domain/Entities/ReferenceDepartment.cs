namespace Domain.Entities
{
    /// <summary>
    /// Связь между подразделениями
    /// </summary>
    public class ReferenceDepartment
    {
        /// <summary>
        /// Id для базы
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Id подразделения-родителя
        /// </summary>
        public Guid ParentDepartmentId { get; set; }

        /// <summary>
        /// Подразделение-родитель
        /// </summary>
        public Department ParentDepartment { get; set; }

        /// <summary>
        /// Id подразделения-ребёнка
        /// </summary>
        public Guid DepartmentId { get; set; }

        /// <summary>
        /// Подразделение-ребёнок
        /// </summary>
        public Department Department { get; set; }
    }
}