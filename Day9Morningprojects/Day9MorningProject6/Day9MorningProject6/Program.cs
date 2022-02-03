using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
//Create Employee class with two constructors as discussed in the class.

namespace Day9MorningProject6
{
    internal class Program
    {
         internal class Employee
         {
            public int id;
            public string name;
            public int salary;
            public static string company = "NATIONSBENEFITS";

            /// <summary>
            /// Default Constructor
            /// </summary>
            public Employee()
            {
                this.id = 0;
                this.name = null;
                this.salary = 0;
            }
            /// <summary>
            /// This is a Constructor with Values of 
            /// </summary>

            public Employee(int eid, string ename, int esalary)
            {
                this.id = eid;
                this.name = ename;
                this.salary = esalary;
            }


            public void ReadData()
            {
                Console.Write("Enter Employee ID : ");
                id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Employee Name : ");
                name = Console.ReadLine();
                Console.Write("Enter Employee Salary : ");
                salary = Convert.ToInt32(Console.ReadLine());
            }
            public void PrintData()
            {

                Console.WriteLine($" Id : {id}, Name : {name}, Salary : {salary}, Company : {company}");
            }

         }
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee(2508, "sarath", 12345);

            // ReadData
            Console.WriteLine("***////with default constructor***/////");
            emp1.ReadData();
            Console.WriteLine("Print Employee data using Default Constructor");
            emp1.PrintData();

            // PrintData
            Console.WriteLine("****** with constructor****");
            Console.WriteLine("Print Employee Data Using Constructor");
            emp2.PrintData();

            Console.ReadLine();
        }
    }
}
