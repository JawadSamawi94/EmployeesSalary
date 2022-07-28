using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Models
{
    public class SalesSalary: IEmployeeSalaryCalculater
    {
        public double BasicSalary { get; set; } = 1000;
        public double Target { get; set; } = 1000;

        public double GetTotalSalary() { return BasicSalary + (Target * 0.15); }
        public bool IsMatch(string Role) { return Role == "Sales"; }
    }
}
