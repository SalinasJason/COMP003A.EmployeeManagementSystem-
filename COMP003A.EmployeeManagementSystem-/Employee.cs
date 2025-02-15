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

        /// <summary>
        /// Gets the _employeeId
        /// </summary>
        public string EmployeeId
        {
            get { return _employeeId; }
        
        }
        
        /// <summary>
        /// Gets and sets FisrtName. The value cannot be empty or null.
        /// </summary>
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("First name cannot be empty. Please try again.");
                    throw new ArgumentException();
                }
                _firstName = value;
            }
        }

        /// <summary>
        ///  Gets and sets LastName. The value cannot be empty or null.
        /// </summary>
        public string LastName
        {
            get { return _lastName; }
            set {

                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Last name cannot be empty. Please try again.");
                    throw new ArgumentException();
                }
                _lastName = value;
            }
        }
        /// <summary>
        ///  Gets and sets MiddleName. The value cannot be null.
        /// </summary>
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

        /// <summary>
        ///  Gets and sets Salary. The value cannot be less then zero.
        /// </summary>
        public double Salary
        {
            get { return _salary; }
            set 
            { 
                 if (value < 0)
                {
                    Console.WriteLine("Salary cannot be less than 0. Please enter a valid value.");
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
