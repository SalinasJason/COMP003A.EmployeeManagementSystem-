using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem_
{
    internal class ITDepartment : Department, IDepartmentOperations
    {
        public ITDepartment(string departmentName)
        {
            DepartmentName = departmentName;
        }

        public override string GetDepartmentDetails()
        {
            return "Manages technical resources and infrastructure.";
        }

        public void Operate()
        {
            Console.WriteLine("Performing IT operations...");
        }
    }
}
