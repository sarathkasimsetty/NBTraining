using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SarathLibrary;

namespace Day16Project5_libraryAPP_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********Class of Mathematics***********");
            Mathematics f = new Mathematics();
            Console.WriteLine("____Factorial_____");
            f.ReadInput();
            Console.WriteLine("Factorial of given number is {0}",f.GetFactorial());

            Console.WriteLine("\n\n***********Class of Physics***********");

            Console.WriteLine("____Find FinalVelocity_____");
            Physics velocity = new Physics();

            Console.WriteLine(velocity.FinalVelocity(5, 2, 2));

            Console.WriteLine("\n\n***********Class of Chemistry***********");
            Chemistry formula = new Chemistry();
            Console.WriteLine("_____Formula____");
            Console.WriteLine("Methane Formula : {0}",formula.GetMethane());
            Console.WriteLine("Water Formula : {0}",formula.GetWater());
            Console.WriteLine("Benzene Formula : {0}",formula.GetBenzene());

            Console.ReadLine();

        }
    }
}
