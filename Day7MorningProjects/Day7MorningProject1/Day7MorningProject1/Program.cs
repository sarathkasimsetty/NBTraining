using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7MorningProject1
{
    internal class Employee   //class of employee
    {
        // private variables
        private int id;
        private string name;
        private int age;
        private int salary;

        // public methods dealswith variables
        public void ReadEmployee() //read values from user
        {
            Console.WriteLine("Enter the EmpId :");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Name :");
            name= Console.ReadLine();

            Console.WriteLine("Enter the Age :");
            age= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Salary :");
            salary = Convert.ToInt32(Console.ReadLine());   
        }

        public void printEmployee() //pint employee details of function call
        {
            Console.WriteLine("EmpID : {0}, Name : {1}, Age : {2}, Salary : {3}", id, name, age, salary);

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(); //read values from user
            emp1.ReadEmployee();
            emp1.printEmployee();

            Console.ReadLine();
        }
    }
}
