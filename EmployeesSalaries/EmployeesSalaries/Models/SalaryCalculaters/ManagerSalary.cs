using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models
{
    public class ManagerSalary : IEmployeeSalaryCalculater
    {
        public double BasicSalary { get; set; } = 1500; 
        public double Bouns { get; set; } = 500;

        public double GetTotalSalary() { return BasicSalary + Bouns; }
        public bool IsMatch(string Role) { return Role == "Manager"; }
    }
}
