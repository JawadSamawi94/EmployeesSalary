namespace EmployeesSalaries.Models.Interfaces
{
    public interface IReportsTo
    {
        IEmployee Manger { get; }
    }
}
