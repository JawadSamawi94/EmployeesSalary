using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models
{
    public class LeadDevSalary : IEmployeeSalaryCalculater
    {
        public double BasicSalary { get; set; } = 1100;

        public double GetTotalSalary() { return BasicSalary; }
        public bool IsMatch(string Role) { return Role == "LeadDev"; }
    }
}
