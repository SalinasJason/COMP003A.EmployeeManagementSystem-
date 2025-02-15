using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem_
{
    /// <summary>
    /// Interface for IDepartmentOperations
    /// </summary>
    internal interface IDepartmentOperations
    {
        /// <summary>
        ///  Method to be used by HRDepartmnet and ITDepartment
        /// </summary>
        void Operate();
    }
}
