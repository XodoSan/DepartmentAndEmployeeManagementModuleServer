namespace Domain.Entities
{
    /// <summary>
    /// Работник
    /// </summary>
    public class Person
    {
        //Табельный номер
        public Guid Id { get; set; }
        //ФИО работника
        public string FIO { get; set; }
        //Id подразделения, в котором состоит данный сотрудник
        public Guid SubdivisionId { get; set; }
        //Подразделение, в котором состоит данный сотрудник
        public Subdivision Subdivision { get; set; }
    }
}