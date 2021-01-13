using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCon.Models
{

    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>(){
            new Employee() { EmployeeName = "Noe"}
         };
        }
        public Employee GetEmployee(string EmployeeName)
        {
            throw new NotImplementedException();
        }
    }
}