using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models.Employee
{
    public class Dev : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public LeadDev Manger { get; set; }

        public int Id { get; }
        public bool IsMatch(int id) { return true;}
    }
}
