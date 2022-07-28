namespace EmployeesSalaries.Models.Interfaces
{
    public interface IEmployeeSalaryCalculater
    {
        public double BasicSalary { get; set; }
        public double GetTotalSalary();
        public bool IsMatch(string Role);
    }
}
