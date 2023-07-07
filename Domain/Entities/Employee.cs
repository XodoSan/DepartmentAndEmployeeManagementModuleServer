namespace Domain.Entities
{
    /// <summary>
    /// Работник
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Табельный номер
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// ФИО работника
        /// </summary>
        public string FIO { get; set; }
        /// <summary>
        /// Id подразделения, в котором состоит данный сотрудник
        /// </summary>
        public Guid DepartmentId { get; set; }
        /// <summary>
        /// Подразделение, в котором состоит данный сотрудник
        /// </summary>
        public Department Department { get; set; }
    }
}