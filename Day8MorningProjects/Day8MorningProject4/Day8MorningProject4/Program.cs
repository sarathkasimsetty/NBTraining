using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
//Create a Department class and add variable of id,name,empcount
//Write code to print id,name of departments whose empcount is greater than 50 using
//for,foreach,lambda,linq query
namespace Day8MorningProject4
{
    internal class Department
    {
        public int Id;
        public string Name;
        public int Empcount;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Department[] departments = new Department[]
            {
             new Department(){Id = 1125 , Name= "cse", Empcount=120 },
             new Department(){Id = 1126,Name = "mech" , Empcount=80 },
             new Department(){Id = 1127,Name = "EEE" , Empcount= 50 },
             new Department(){Id = 1128,Name = "civil" , Empcount=30 }
            };

            //for loop
            Console.WriteLine("***************for loop***********");
            for(int i=0;i<departments.Length;i++)
            {
                if(departments[i].Empcount > 50)
                    Console.WriteLine("DepID = {0} , DepName = {1}",departments[i].Id,departments[i].Name);
            }

            //foreach loop
            Console.WriteLine("***************foreach loop***********");
            foreach (var d in departments)
            {
                if (d.Empcount > 50) 
                Console.WriteLine("DepID = {0} , DepName = {1}", d.Id, d.Name);
            }

            //Lambda expression
            Console.WriteLine("************Lambda expression**************");
            departments.Where(d => d.Empcount > 50).ToList().ForEach(d => Console.WriteLine("DepID = {0} , DepName = {1}", d.Id, d.Name));

            //LinQ query
            Console.WriteLine("***********LinQ query***************");
            var result = from p in departments
                         where p.Empcount > 50
                         select p;
            result.ToList().ForEach(p => Console.WriteLine("DepID = {0} , DepName = {1}", p.Id, p.Name));

            Console.ReadLine();
           
        }
    }
}
