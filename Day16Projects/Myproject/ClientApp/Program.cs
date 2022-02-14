using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SarathLibrary;
using PublicLibrary;
//sarath kasimsetty
//Create a solution "MyProject" (as discussed in class)
//ClientApp (and here refer above two libraries)
namespace ClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("______ApowerB______");
            Console.WriteLine("5 Power 3 is {0}",Mathematics.aPowerb(5, 3));

            Console.WriteLine("\n__________Factorial___________");
            Console.WriteLine("Factorial of 6 is {0}",Mathematics.Factorial(6));

            Console.WriteLine("\n_______Find Velocity_______");
            Console.WriteLine("u = 5, a = 5, t = 5 is {0}",Physics.FindVelocity(5, 5, 5));

            Console.ReadLine();
        }
    }
}
