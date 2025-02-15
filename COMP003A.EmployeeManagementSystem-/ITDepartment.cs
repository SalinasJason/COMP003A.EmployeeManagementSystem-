using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem_
{
    /// <summary>
    /// Represents ITDepartment derived from Department
    /// </summary>
    internal class ITDepartment : Department, IDepartmentOperations
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="departmentName"></param>
        public ITDepartment(string departmentName)
        {
            DepartmentName = departmentName;
        }

        /// <summary>
        /// Overides GetDepartmentDetails
        /// </summary>
        /// <returns>  Returns ITDepartment details </returns>
        public override string GetDepartmentDetails()
        {
            return "Manages technical resources and infrastructure.";
        }

        /// <summary>
        /// Implments Operate() method
        /// </summary>
        public void Operate()
        {
            Console.WriteLine("Performing IT operations...");
        }
    }
}
