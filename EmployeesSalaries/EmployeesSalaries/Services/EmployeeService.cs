using EmployeesSalaries.Models.Employee;
using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Services
{
    public class EmployeeService : IEmployeeService
    {
        private List<IEmployee> employees = new List<IEmployee>{ 
            new Manager{ FirstName="TestManager",LastName="TestManager",Role="Manager"}, 
            new Sales{ FirstName="TestSales",LastName="TestSales",Role="Sales"}, 
            new LeadDev{ FirstName="TestLeadDev",LastName="TestLeadDev",Role="LeadDev"}, 
            new HR{ FirstName="TestHR",LastName="TestHR",Role="HR"}, 
            new Dev{ FirstName="TestDev",LastName="TestDev",Role="Dev"}
        };
        private List<IReportsTo> employeesReportsTo = new List<IReportsTo>{
            new Sales{ FirstName="TestSales",LastName="TestSales",Role="Sales"},
            new LeadDev{ FirstName="TestLeadDev",LastName="TestLeadDev",Role="LeadDev"},
            new HR{ FirstName="TestHR",LastName="TestHR",Role="HR"},
            new Dev{ FirstName="TestDev",LastName="TestDev",Role="Dev"}
        };
        public IEmployee GetEmployee(int id)
        {
            return employees.First(employee => employee.IsMatch(id));
        }
        public List<IEmployee> GetEmployees()
        {
            return employees;
        }
        public IReportsTo GetEmployeeReportsTo(int employeeId)
        {
            var emp = employeesReportsTo.FirstOrDefault(emp => emp.ReportsTo(employeeId));
            if(emp == null)
            {
                throw new Exception("Not Assignable");
            } 
            else
            {
                return emp;
            }
        }
    }
}

