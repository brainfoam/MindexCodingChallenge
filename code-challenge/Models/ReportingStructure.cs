//Written by Joseph Aquiare for the Mindex coding challenge.

using System;

namespace challenge.Models
{
    public class ReportingStructure
    {
        /// <summary>
        /// Creates a new reporting structure.
        /// </summary>
        public ReportingStructure(Employee employee) 
        {
            Employee = employee;
        }

        /// <summary>
        /// Collects the amount of reports that an employee has under them.
        /// </summary>
        /// <param name="e">The employee being analyzed.</param>
        private int CollectReports(Employee employee)
        {
            int reportCount = 0;

            //Apply to all children
            foreach (Employee under in employee.DirectReports)
            {
                try
                {
                    reportCount += CollectReports(under) + 1; //Add self and children to report count
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine($"Employee reference null at ID \"{_employee.EmployeeId}\"");
                }
            }

            return reportCount;
        }

        /// <summary>
        /// The employee reference.
        /// </summary>
        public Employee Employee { get; set; }

        /// <summary>
        /// The total number of reports under a given employee.
        /// </summary>
        public int NumberOfReports 
        { 
            get { return CollectReports(Employee); }
        }
    }
}
