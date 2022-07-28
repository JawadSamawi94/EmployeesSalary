using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models.Employee
{
    public class Dev : IEmployee, IReportsTo
    {
        public string FirstName { get; set; } = "Test";
        public string LastName { get; set; } = "Test";
        public string Role { get; set; } = "Dev"; 
        public IEmployee Manger { get; } = new LeadDev();

        public int Id { get; } = 4;
        public bool IsMatch(int id) { return true;}
    }
}
