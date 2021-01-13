using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCon.Models
{
    public class Employee
    {
        public string EmployeeName { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeePassword { get; set; }
        public string IdLogin{ get; set; }

        public string EmployeePermission { get; set; }
        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public Boolean PhoneNumberConfirmed { get; set; }
        public Boolean TwoFactorEnabled { get; set; }
        public string LockoutEndDateUtc { get; set; }
        public string LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public int UserName { get; set; }
        public int EmailConfirmed { get; set; }



    }
}
