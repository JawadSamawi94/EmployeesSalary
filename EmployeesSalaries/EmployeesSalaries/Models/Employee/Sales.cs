using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models.Employee
{
    public class Sales : IEmployee, IReportsTo
    {
        public string FirstName { get; set; } = "Test";
        public string LastName { get; set; } = "Test";
        public string Role { get; set; } = "Sales";
        public IEmployee Manger { get; } = new Manager();

        public int Id { get; } = 1;
        public bool IsMatch(int id) { return id == Id; }
    }
}
