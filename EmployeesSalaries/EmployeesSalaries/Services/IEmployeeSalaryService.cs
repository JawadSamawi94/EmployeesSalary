using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Services
{
    public interface IEmployeeSalaryService
    {
        //IEmployeeSalaryCalculater EmployeeSalaryCalc {get;}
        //void GetEmployeeCalculater (IEmployee employee);
        double CalcSalary(IEmployee employee);
    }
}
