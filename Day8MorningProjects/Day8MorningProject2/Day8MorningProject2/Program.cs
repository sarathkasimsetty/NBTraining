using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
//Create a class Employee with three variables as discussed in the class and create a list of Employees
//public int id;public string name;public int salary;
namespace Day8MorningProject2
{
    internal class Employee
    {
        public int Id;
        public string Name;
        public int salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees= new List<Employee>()
            {
                new Employee(){Id = 121 , Name = "sarath" , salary = 6000},
                new Employee(){Id = 122 , Name = "suresh" , salary = 1500},
                new Employee(){Id = 123 , Name = "sai" ,  salary = 4000},
                new Employee(){Id = 124 , Name = "pushpa" , salary = 7500},
            };

            //for loop
            Console.WriteLine("*********for loop********");
            for (int i =0; i <employees.Count;i++)
            {
                if(employees[i].salary>5000)
                Console.WriteLine(employees[i].Name);        
            }

            //foreach loop\
            Console.WriteLine("*********foreach loop********");
            foreach (var d in employees)
            {
                if(d.salary>5000)
                Console.WriteLine(d.Name);
            }

            //Lambda expression
            Console.WriteLine("*********lambda expression********");
            employees.Where(d=>d.salary>5000).ToList().ForEach(d=> Console.WriteLine(d.Name));

            //LinQ query
            Console.WriteLine("*********LinQ query********");
            var result = from d in employees
                         where d.salary>5000
                         select d;
            result.ToList().ForEach(f => Console.WriteLine(f.Name));

            Console.ReadLine();

        }
          
    }
}
