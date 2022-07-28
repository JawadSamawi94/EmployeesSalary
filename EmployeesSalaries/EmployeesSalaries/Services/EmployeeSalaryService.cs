using EmployeesSalaries.Models;
using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Services
{
    public class EmployeeSalaryService : IEmployeeSalaryService
    {
        List<IEmployeeSalaryCalculater> salaryCalculaters = new List<IEmployeeSalaryCalculater> { 
            new ManagerSalary(),
            new SalesSalary(),
            new LeadDevSalary(),
            new HRSalary(),
            new DevSalary()
        };
        public double CalcSalary(IEmployee employee)
        {
            IEmployeeSalaryCalculater calc = GetCalculater(employee);
            return calc.GetTotalSalary();
        }
        private IEmployeeSalaryCalculater GetCalculater(IEmployee employee)
        {
            IEmployeeSalaryCalculater calculater = salaryCalculaters.Find(calc => calc.IsMatch(employee.Role));
            if (calculater == null) throw new Exception("Calculater Not Impelmented");
            return calculater;
        }
    }
}
