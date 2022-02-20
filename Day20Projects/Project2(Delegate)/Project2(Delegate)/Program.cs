using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//SARATH KASIMSETTY
//Write C# code to illustrate the usage of delegates.

namespace Project2_Delegate_
{
    public delegate void AlgebraCaller(int a, int b);
    class Algebra
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Add : {0}",a + b);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine("Subtraction : {0}",a - b);
        }
        public void Mul(int a, int b)
        {
            Console.WriteLine("Multiple : {0}",a * b);
        }
        public void Mod(int a, int b)
        {
            Console.WriteLine("Modulo : {0}",a % b);
        }
    }
    internal class Program
    {    
        static void Main(string[] args)
        {
            //creating class of object
            Algebra algebra = new Algebra();
            //Creating delegate of object 
            //call from delegate all your methods
            AlgebraCaller caller = new AlgebraCaller(algebra.Add);
            caller += algebra.Sub;
            caller += algebra.Mul;
            caller += algebra.Mod;
            //Call the methods of diference values
            Console.WriteLine("Algebra of two numbers 5 and 6");
            caller(5, 6);
            Console.WriteLine("\n");
            Console.WriteLine("Algebra of two numbers 15 and 10");
            caller(15, 10);
            Console.WriteLine("\n");
            Console.WriteLine("Algebra of two numbers 24 and 12");
            caller(24, 12);

            Console.ReadLine();
        }
    }
}
