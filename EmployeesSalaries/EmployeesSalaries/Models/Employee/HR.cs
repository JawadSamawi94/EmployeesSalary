using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models.Employee
{
    public class HR : IEmployee, IReportsTo
    {
        public string FirstName { get; set; } = "Test";
        public string LastName { get; set; } = "Test";
        public string Role { get; set; } = "HR";
        public IEmployee Manger { get;  } = new Manager();

        public int Id { get; } = 3;

        public bool IsMatch(int id) { return id == Id; }
    }

}
