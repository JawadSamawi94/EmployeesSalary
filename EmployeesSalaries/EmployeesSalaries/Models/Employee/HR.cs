using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models.Employee
{
    public class HR : IEmployee, IReportsTo
    {
        public string FirstName { get; set; } = "Test";
        public string LastName { get; set; } = "Test";
        public string Role { get; set; } = "HR";
        public IEmployee Manager { get; set; } = new Manager();

        public int Id { get; } = 3;

        public bool IsMatch(int id) { return id == Id; }
        public bool ReportsTo(int id) { return id == Id; }
        public IEmployee Assign(IEmployee manager) {
            if (manager.Role == "Manager") 
            {
                Manager = manager;
                return this;
            }
            else
            {
                throw new BadHttpRequestException($"HR Reports to Manager and not to {manager.Role}");
            }
        }
    }

}
