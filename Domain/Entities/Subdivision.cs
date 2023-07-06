namespace Domain.Entities
{
    /// <summary>
    /// Подразделение
    /// </summary>
    public class Subdivision
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Person>? Persons { get; set; }
    }
}