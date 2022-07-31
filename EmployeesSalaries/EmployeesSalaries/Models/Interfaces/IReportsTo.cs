namespace EmployeesSalaries.Models.Interfaces
{
    public interface IReportsTo
    {
        IEmployee Manager { get; }
        IEmployee Assign(IEmployee manager);
        bool ReportsTo(int id);
    }
}
