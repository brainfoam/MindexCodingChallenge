//Written by Joseph Aquiare for the Mindex coding challenge.

using System;
using System.ComponentModel.DataAnnotations;

namespace challenge.Models
{
    public class Compensation
    {
        [Key] public string EmployeeId { get; set; } //Primary key for data transfer
        private int _salary;
        private DateTime _effectiveDate;

        /// <summary>
        /// Creates a new compensation container.
        /// </summary>
        /// <param name="_employee">The employee reference.</param>
        /// <param name="_salary">Their salary.</param>
        /// <param name="_effectiveDate">Their effective date.</param>
        public Compensation(string employeeID = null, int salary = 0, DateTime effectiveDate = default(DateTime))
        {
            _salary        = salary;
            _effectiveDate = effectiveDate;
            EmployeeId     = employeeID; //Set employee ID
        }

        /// <summary>
        /// The compensation the employee is recieving.
        /// </summary>
        public int Salary { get { return  Math.Clamp(_salary, 0, int.MaxValue); } set { _salary = value; } }

        /// <summary>
        /// The employee's effective date and time of employment.
        /// </summary>
        public DateTime EffectiveDate { get { return _effectiveDate; } set { _effectiveDate = value; } }
        
        
    }
}
