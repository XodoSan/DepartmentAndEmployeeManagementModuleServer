namespace Infrastructure.Exceptions
{
    /// <summary>
    /// Кастомная ошибка неверного имени сотрудника
    /// </summary>
    public class InvalidEmployeeNameException : Exception
    {
        public InvalidEmployeeNameException() { }

        public InvalidEmployeeNameException(string name)
        : base(string.Format("Invalid employee name: {0}", name))
        {

        }
    }
}