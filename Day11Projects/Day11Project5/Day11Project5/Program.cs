using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//SARATH KASIMSETTY
//Write sample code to illustrate properties as discussed in class.
//id,name,designation,salary
//designation-set (writeonly)
//salary - get(get with some functionality)

namespace Day11Project5
{
    /// <summary>
    /// properties class 
    /// </summary>
    class Employee
    {
        private int id;
        private string name;
        private string designation;
        

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Designation
        {
            set { designation = value; }
        }
        public int Salary
        {
            get {
                if (designation == "M")
                    return 90000;
                else if (designation == "EMP")
                    return 50000;
                else 
                 return 15000;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();

            Console.WriteLine("******MANAGER DETAILS******");
            emp1.Id = 20;
            emp1.Name = "JK";
            emp1.Designation = "M";
            Console.WriteLine("empId = {0} , empName = {1} , salary = {2}",emp1.Id, emp1.Name, emp1.Salary);

            Employee emp2 = new Employee();

            Console.WriteLine("******EMPLOYEE DETAILS******");
            emp2.Id = 20;
            emp2.Name = "sarath";
            emp2.Designation = "EMP";
            Console.WriteLine("empId = {0} , empName = {1} , salary = {2}", emp2.Id, emp2.Name, emp2.Salary);

            Console.ReadLine();
        }
    }
}
