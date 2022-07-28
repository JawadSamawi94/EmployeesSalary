using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models.Employee
{
    public class Manager : IEmployee
    {
        public string FirstName { get; set; } = "Test";
        public string LastName { get; set; } = "Test";
        public string Role { get; set; } = "Manager";

        public int Id { get; } = 0;
        public bool IsMatch(int id) { return id == Id; }
    }
}
