using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models.Employee
{
    public class Dev : IEmployee, IReportsTo
    {
        public string FirstName { get; set; } = "Test";
        public string LastName { get; set; } = "Test";
        public string Role { get; set; } = "Dev"; 
        public IEmployee Manager { get; set; } = new LeadDev();

        public int Id { get; } = 4;
        public bool IsMatch(int id) { return true; }
        public bool ReportsTo(int id) { return id >= Id; }

        public IEmployee Assign(IEmployee manager) {
            if (manager.Role == "LeadDev") 
            {
                Manager = manager;
                return this;
            } 
            else
            {
                throw new BadHttpRequestException($"Dev Reports to LeadDev and not to {manager.Role}");
            }
        }
    }
}
