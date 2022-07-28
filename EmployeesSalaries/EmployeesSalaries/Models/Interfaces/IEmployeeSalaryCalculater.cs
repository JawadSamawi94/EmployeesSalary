namespace EmployeesSalaries.Models.Interfaces
{
    public interface IEmployeeSalaryCalculater
    {
        double BasicSalary { get; set; }
        double GetTotalSalary();
        bool IsMatch(string Role);
    }
}
