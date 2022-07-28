using EmployeesSalaries.Models.Employee;
using EmployeesSalaries.Models.Interfaces;
using EmployeesSalaries.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesSalaries.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        private IEmployeeService _employeeService ;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public List<IEmployee> GetEmployees()
        {
            return _employeeService.GetEmployees();
        }
        [HttpGet("{id}")]
        public IEmployee GetEmployee(int id)
        {
            return _employeeService.GetEmployee(id);
        }
    }
}
