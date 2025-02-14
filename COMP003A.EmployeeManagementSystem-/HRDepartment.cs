using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem_
{
    internal class HRDepartment : Department
    {

        public HRDepartment(string departmentName)
        {
            DepartmentName = departmentName;
        }
 
        public override string GetDepartmentDetails()
        {
            return "Handles employee relations and recruitment.";
        }
    }
}
