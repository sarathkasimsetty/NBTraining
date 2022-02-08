using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
//Create a class Employee with only properties.

namespace Day11Project6
{
    /// <summary>
    /// properties of private variables
    /// </summary>
    internal class Employee
    {
        private int id;
        private string name;
        private int salary;

        
        public int Id
        {
            get { return id; } //read the value
            set { id = value; }//print  the value
        }
        public string Name
        {
            get { return name; } 
            set { name = value; }
        }

        public int Salary
        {
            get { return salary;}//read the value
            set { salary = value; }//print the  value
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();

            emp1.Id = 12;
            emp1.Name = "john";
            emp1.Salary = 80000;

            Employee emp2 = new Employee();
            emp2.Id = 15;
            emp2.Name = "sarath";
            emp2.Salary = 10000;


            Console.WriteLine("Id = {0} , Name = {1}, salary = {2}",emp1.Id,emp1.Name,emp1.Salary);
            Console.WriteLine("Id = {0} , Name = {1}, salary = {2}", emp2.Id, emp2.Name, emp2.Salary);

            Console.ReadLine();
        }
    }
}
