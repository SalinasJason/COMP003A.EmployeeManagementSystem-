using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem_
{
    /// <summary>
    /// Represents HRDepartment derived from Department
    /// </summary>
    internal class HRDepartment : Department, IDepartmentOperations
    {

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="departmentName"></param>
        public HRDepartment(string departmentName)
        {
            DepartmentName = departmentName;
        }

        /// <summary>
        /// Overides GetDepartmentDetails 
        /// </summary>
        /// <returns> Returns HRDepartment detailss </returns>
        public override string GetDepartmentDetails()
        {
            return "Handles employee relations and recruitment.";
        }

        /// <summary>
        /// Implments Operate() method
        /// </summary>
        public void Operate()
        {
            Console.WriteLine("Performing HR operations...");
        }
    }
}
