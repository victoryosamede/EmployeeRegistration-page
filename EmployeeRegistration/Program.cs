using EmployeeRegistration;
class Program
{
    static void Main(string[] args)
    {
        using (var context = new EmployeeRegistrationDbContext())
        {
            var employee = new Employee()
            {
                FirstName = "Victory",
                LastName = "Uhunmwangho",
                Age = 30,
                Gender = Gender.Male,
               

            };

            context.Employees.Add(employee);
            context.SaveChanges();
        }
    }
}