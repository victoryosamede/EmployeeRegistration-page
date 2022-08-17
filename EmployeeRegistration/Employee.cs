namespace EmployeeRegistration
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public List<Child> Children { get; set; }
    }
}
