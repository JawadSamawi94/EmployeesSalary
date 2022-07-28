using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models.Employee
{
    public class HR : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public Manager Manger { get; set; }

        public int Id { get; } = 3;
        public bool IsMatch(int id) { return id == Id; }
    }
}
