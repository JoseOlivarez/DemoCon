using DemoCon.Models;
namespace DemoCon
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(string EmployeeName);
    }
}