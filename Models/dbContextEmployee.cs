using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace DemoCon.Models
{
    public class dbContextEmployee : DbContext
    {
      
        public DbSet<Employee> EmployeeName { get; set; }


    }
}
