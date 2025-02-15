using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem_
{
    /// <summary>
    /// Represents an abstract class for Departments
    /// </summary>
    internal abstract class Department
    {
        /// <summary>
        /// Gets and sets DepartmentName
        /// </summary>
        public string DepartmentName
        {
            get; set;
        }

        /// <summary>
        /// Abstract method to GetDepartmentDetails
        /// </summary>
        /// <returns> Returns the string details </returns>
        public abstract string GetDepartmentDetails();

        /// <summary>
        /// Displays Department Information
        /// </summary>
        public void DisplayDepartmentInfo()
        {
            Console.WriteLine($"\nDepartment: {DepartmentName}");
        }
    }
}
