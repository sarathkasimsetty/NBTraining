using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
//Create an employee class with below variables id, name, salary, company
 //write methods to read data and print data.

namespace Day9MorningProject3
{
    internal class Employee
    {
        private int Id;
        private string Name;
        private int Salary;
        /// <summary>
        /// Company is common for all employees
        /// </summary>
        private static string Company = "NBtech"; 
        /// <summary>
        /// Read input from user to employees object
        /// </summary>
        public void Readinput()
        {
            Console.WriteLine("Enter the Empid :");
            Id =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Empname :");
            Name = Console.ReadLine();

            Console.WriteLine("Enter the Salary :");
            Salary = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// Print the employees details for the user inputs
        /// </summary>
        public void Printinput()
        {
            Console.WriteLine("EmpId : {0} , Name : {1} , Salary : {2} , Company = {3}",Id,Name,Salary,Company);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee(); 
            
            emp1.Readinput();
            emp2.Readinput();

            Console.WriteLine("*******Emp1 details********");
            emp1.Printinput();

            Console.WriteLine("*******Emp2 details********");
            emp2.Printinput();

            Console.ReadLine();

        }
    }
}
