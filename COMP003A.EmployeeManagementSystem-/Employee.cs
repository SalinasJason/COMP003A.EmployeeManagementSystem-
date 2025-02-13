using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem_
{
    internal class Employee
    {
        private string _employeeId;
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private double _salary;

        public string EmployeeId
        {
            get { return _employeeId; }
            set { _employeeId = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string MiddleName
        {
            get { return _middleName; } 
            set { _middleName = value; }
        }

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public Employee(string inputEmployeeId, string inputFirstName, string inputMiddleName, string inputLastName, double inputSalary)
        {
            EmployeeId = inputEmployeeId;
            FirstName = inputFirstName;
            MiddleName = inputMiddleName;
            LastName = inputLastName;
            Salary = inputSalary;
        }

        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {MiddleName} {LastName}");
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.Write($"Name: ");
            PrintFullName();
            Console.WriteLine($"Salary: ${Salary:F2}");
        }
    }
}
