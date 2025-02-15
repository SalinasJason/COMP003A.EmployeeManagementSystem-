// Author: Jason Salinas
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Employee management system demonstrating OOP principles in C#
namespace COMP003A.EmployeeManagementSystem_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DisplayEmployeeInfo();
            DisplayDepartmentInfo();
        }

        /// <summary>
        /// Method to Display Employee Information
        /// </summary>
        static void DisplayEmployeeInfo()
        {
            Console.Write("Enter Employee ID: ");
            string userInputEmployeeId = Console.ReadLine();

            Console.Write("Enter first name: ");
            string userInputFirstName = Console.ReadLine();

            Console.Write("Enter middle name (Press Enter to skip): ");
            string userInputMiddleName = Console.ReadLine();

            Console.Write("Enter last name: ");
            string userInputLastName = Console.ReadLine();

            double userInputSalary;

            while (true)
            {
                Console.Write("Enter Salary: ");
                try
                {
                    userInputSalary = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Salary must be a valid number. Please enter a valid value.");
                }
            }

            Employee employee = new Employee(userInputEmployeeId, userInputFirstName, userInputMiddleName, userInputLastName, userInputSalary);
            Console.WriteLine("\nEmployee Created Succesfully\n");


            employee.DisplayEmployeeInfo();


        }

        /// <summary>
        /// Merhod to Display Department Information
        /// </summary>
        static void DisplayDepartmentInfo()
        {

            HRDepartment departmentHR = new HRDepartment("Human resources");
            departmentHR.DisplayDepartmentInfo();
            Console.WriteLine($"Details: {departmentHR.GetDepartmentDetails()}");
            departmentHR.Operate();

            ITDepartment departmentIT = new ITDepartment("IT");
            departmentIT.DisplayDepartmentInfo();
            Console.WriteLine($"Details: {departmentIT.GetDepartmentDetails()}");
            departmentIT.Operate();
        }


    }
}
