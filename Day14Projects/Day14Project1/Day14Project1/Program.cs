using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
//Research and write what is the use of sealed class.
//WACP to illustrate sealed class.

namespace Day14Project1
{
     class TataSteel
     {
        public int id;
        public string name;
        public static string Company = "TATA GROUP";
        public virtual void GetReadEmployee()
        {
            //Read the value from user
            Console.WriteLine("Enter a Login Id ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Name :");
            name = Console.ReadLine();
        }
        public virtual void GetDisplayEmpDetails()
        {
            Console.WriteLine("ID: {0} , Name = {1} , Company = {2}", id, name, Company);
        }
    }

     sealed class TataMotors : TataSteel 
        //TataMotors is a derived of TataSteel(base)
     {

        public override void GetReadEmployee()
        {
            Console.WriteLine("Enter a Login Id ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Name :");
            name = Console.ReadLine();
        }

        public override void GetDisplayEmpDetails()
        {
            Console.WriteLine("ID: {0} , Name = {1} , Company = {2}",id,name,Company);
        }
    }
    sealed class CompanyMark
    {

        public static string CompanyLocation = "Hyderabad";
         
    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Location : {0}",CompanyMark.CompanyLocation);

            Console.WriteLine("*******Emp Details*******");
            TataSteel emp = new TataSteel();
            emp.GetReadEmployee();
            emp.GetDisplayEmpDetails();
            Console.ReadLine();

        }
    }
}
