using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinesslogicLayer;

namespace SarathClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            string ch;
            do
            {
                Console.WriteLine("\n*----*----*----*-----*----*----*----*");
                Console.WriteLine("EMPLOYEES MANAGEMENT APPLICATION");
                Console.WriteLine("*----*----*----*-----*----*----*----*\n");
                Console.WriteLine("1. Add Employee details");
                Console.WriteLine("2. Search Employeedetail by ID");
                Console.WriteLine("3. Search Employeedetail bt NAME");
                Console.WriteLine("4. Display AllEmployees details");
                Console.WriteLine("\nEnter choice your Requirment : ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddEmployee();
                        break;

                    case 2:
                        SearchEmployeeByID();
                        break;

                    case 3:
                        SearchEmployeeByName();
                        break;
                    case 4:
                        DisplayEmployees();
                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                Console.WriteLine("Do you want to continue (y/n) :");
                ch = Console.ReadLine();
            } while (ch.Equals( "y"));
        }
        public static void AddEmployee()
        {
            Console.WriteLine("\nEnter Employee ID");
            int EmpId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee NAME");
            string EmpName = Console.ReadLine();

            Console.WriteLine("Enter Employee SALARY");
            int EmpSalary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee AGE");
            int EmpAge = Convert.ToInt32(Console.ReadLine());

            var result = EmployeeBLL.GetEmployeeAdd(EmpId, EmpName, EmpSalary, EmpAge);

            if(result)
            {
                Console.WriteLine("EMployee Details save sucessfully");
            }
            else
                Console.WriteLine("Some Error");

        }
        public static void SearchEmployeeByID()
        {
            Console.WriteLine("\nEnter the employee ID :");
            int empId = Convert.ToInt32(Console.ReadLine());

            var result = EmployeeBLL.GetEmployeeById(empId);
            if (result.Count == 0)
            {
                Console.WriteLine("No record exist with this Id");
            }
            else
            {
                result.ForEach(p => Console.WriteLine(p));
            }


        }
        public static void SearchEmployeeByName()
        {
            Console.WriteLine("\nEmter the employee Name :");
            string empName = Console.ReadLine();

            var result = EmployeeBLL.GetEmployeeByName(empName);

            if (result.Count == 0)
            {
                Console.WriteLine("No record exist with Name");
            }
            else 
            {
                result.ForEach(p => Console.WriteLine(p));
            }
        }
        public static void DisplayEmployees()
        {
            var result = EmployeeBLL.GetALlEmployees();
            Console.WriteLine("\nDisplaying All employees in the file");
            foreach (var employee in result)
            {
                Console.WriteLine(employee);
            }     
        }

    }
}
