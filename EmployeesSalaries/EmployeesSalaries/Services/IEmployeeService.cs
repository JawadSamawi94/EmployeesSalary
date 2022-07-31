using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Services
{
    public interface IEmployeeService
    {
        public IEmployee GetEmployee(int id);
        public List<IEmployee> GetEmployees();
        public IReportsTo GetEmployeeReportsTo(int id);
    }
}
