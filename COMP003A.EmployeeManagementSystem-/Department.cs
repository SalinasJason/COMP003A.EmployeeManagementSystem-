using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem_
{
    internal abstract class Department
    {
        public string DepartmentName
        {
            get; set;
        }

        public abstract string GetDepartmentDetails();

        public void DisplayDepartmentInfo()
        {
            Console.WriteLine($"{DepartmentName}");
        }
    }
}
