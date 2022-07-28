using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Services
{
    public interface IEmployeeSalaryService
    {
        public double CalcSalary(IEmployee employee);
    }
}
