namespace EmployeesSalaries.Models.Interfaces
{
    public interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Role { get; set; }
        int Id { get; }
        bool IsMatch(int id);
    }
}
