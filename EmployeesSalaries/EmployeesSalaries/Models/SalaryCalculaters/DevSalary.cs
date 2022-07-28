using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models
{
    public class DevSalary : IEmployeeSalaryCalculater
    {
        public double BasicSalary { get; set; } = 800;

        public double GetTotalSalary() { return BasicSalary; }
        public bool IsMatch(string Role) { return Role == "Dev"; }
    }
}
