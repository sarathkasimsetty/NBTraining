using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project2
{
    internal class Program
    {
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
                set
                {
                    designation = value;
                }
            }
            public int Salary
            {
                get
                {
                    if (designation == "M")
                        return 100000;

                    else if (designation == "HR")
                        return 60000;

                    else if (designation == "TR")
                        return 50000;
                    else
                        return 35000;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n --------------**** NB Salary Details ****--------------\n");

            Employee emp1 = new Employee();
            emp1.Id = 54;
            emp1.Name = "john";
            emp1.Designation = "M";

            Console.WriteLine($"{ emp1.Id}, { emp1.Name}, { emp1.Salary}");

            Employee emp2 = new Employee();
            emp1.Id = 102;
            emp1.Name = "sarath";
            emp1.Designation = "new";

            Console.WriteLine($"{ emp1.Id}, { emp1.Name}, { emp1.Salary}");

            Console.ReadLine();

        }
    }
}
