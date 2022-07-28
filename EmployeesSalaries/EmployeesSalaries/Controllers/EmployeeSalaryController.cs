using EmployeesSalaries.Models.Interfaces;
using EmployeesSalaries.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesSalaries.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeSalaryController : Controller
    {
        private IEmployeeService _employeeService;
        private IEmployeeSalaryService _salaryService;
        public EmployeeSalaryController(IEmployeeService employeeService, IEmployeeSalaryService salaryService)
        {
            _employeeService = employeeService;
            _salaryService = salaryService;
        }
        [HttpGet("{id}")]
        public double Get(int id)
        {
            IEmployee employee = _employeeService.GetEmployee(id);

            return _salaryService.CalcSalary(employee);
        }
    }
}
