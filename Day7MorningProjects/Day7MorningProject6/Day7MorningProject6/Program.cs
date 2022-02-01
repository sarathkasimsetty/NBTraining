﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
//create employees array object and initialize with 5 employees
//write code using for loop,for loop ,lambda expression.
namespace Day7MorningProject6
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
            Employee[] employees = new Employee[]
            {
                new Employee(){Id = 101, Name = "sarath", salary=1000},
                new Employee(){Id = 102, Name = "phani" , salary=1200},
                new Employee(){Id = 103, Name = "suresh", salary=1400},
                new Employee(){Id = 104, Name = "ramesh", salary=1500},
                new Employee(){Id = 105, Name = "mahesh", salary=1700}
            };

            //forloop
            Console.WriteLine("**************************Print by using For Loop**********************");
            for (int i=0;i<employees.Length;i++)
            {
                Console.WriteLine($"EmpId = {employees[i].Id}, EmpName = {employees[i].Name}, Empsalary = {employees[i].salary}");
            }

            //foreach loop
            Console.WriteLine("**************************Print by using Foreach Loop**********************");
            foreach (var d in employees)
            {   
                Console.WriteLine("Empid = {0},EmpName = {1},Empsalary = {2}",d.Id,d.Name,d.salary);
            }
            //lambda expression
            Console.WriteLine("**************************Print by using Lambda expression**********************");
            employees.ToList().ForEach(e => Console.WriteLine("Empid = {0},EmpName = {1},Empsalary = {2}", e.Id, e.Name, e.salary));

            Console.ReadLine();
        }
    }
}
