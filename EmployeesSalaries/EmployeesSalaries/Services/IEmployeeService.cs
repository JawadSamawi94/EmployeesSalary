using EmployeesSalaries.Models.Interfaces;

namespace EmployeesSalaries.Services
{
    public interface IEmployeeService
    {
        IEmployee GetEmployee(int id);
    }
}
