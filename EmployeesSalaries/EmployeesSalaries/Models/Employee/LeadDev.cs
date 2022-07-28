using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models.Employee
{
    public class LeadDev : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public Manager Manger { get; set; }

        public int Id { get; } = 2;
        public bool IsMatch(int id) { return id == Id; }
    }
}
