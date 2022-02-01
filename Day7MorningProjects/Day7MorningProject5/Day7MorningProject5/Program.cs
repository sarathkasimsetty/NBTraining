using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// sarath kasimsetty
//Create Employee object and initialize with values while creating object and print the values.
namespace Day7MorningProject5
{
    internal class Employee
    {
        public int Id;
        public string Name;
        public int Salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee() { Id = 12, Name = "sarath", Salary = 265626 };

            Console.Write("EmpId = {0} , Name= {1}  ,Salary ={2}", emp.Id, emp.Name, emp.Salary);
            Console.ReadLine();

        }
    }
}
