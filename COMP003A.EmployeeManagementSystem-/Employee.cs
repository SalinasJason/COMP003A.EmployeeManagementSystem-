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

        // Fields
        private string _employeeId;
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private double _salary;

        // Properties
        public string EmployeeId
        {
            get { return _employeeId; }
        
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw ArgumentException();
                }
                _firstName = value;
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set {

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }
                _lastName = value;
            }
        }

        public string MiddleName
        {
            get { return _middleName; } 
            set 
            {
                if (value == null)
                {
                    throw new ArgumentException();
                }
                _middleName = value;
            }
        }

        public double Salary
        {
            get { return _salary; }
            set 
            { 
                 if (value <= 0)
                {
                    throw new ArgumentException();
                }
                _salary = value; 
            }
        }


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="inputEmployeeId"></param>
        /// <param name="inputFirstName"></param>
        /// <param name="inputMiddleName"></param>
        /// <param name="inputLastName"></param>
        /// <param name="inputSalary"></param>
        public Employee(string inputEmployeeId, string inputFirstName, string inputMiddleName, string inputLastName, double inputSalary)
        {
            _employeeId = inputEmployeeId;
            FirstName = inputFirstName;
            MiddleName = inputMiddleName;
            LastName = inputLastName;
            Salary = inputSalary;
        }

        /// <summary>
        /// Prints Full Name
        /// </summary>
        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {MiddleName} {LastName}");
        }

        /// <summary>
        /// Displays Employee Information
        /// </summary>
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.Write($"Name: ");
            PrintFullName();
            Console.WriteLine($"Salary: ${Salary:F2}");
        }
    }
}
