using challenge.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace challenge.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }

        /// <summary>
        /// Employee Data Set
        /// </summary>
        public DbSet<Employee> Employees { get; set; } 

        /// <summary>
        /// Employee Compensation Data Set
        /// </summary>
        public DbSet<Compensation> Compensations { get; set; }
    }
}
