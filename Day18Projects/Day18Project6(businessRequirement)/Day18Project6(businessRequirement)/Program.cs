using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathematicsLibrary;
/// <summary>
/// layered architectureproject with seperate class library for Business logic.
/// </summary>
namespace Day18Project6_businessRequirement_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                //Read input from user
                Console.Write("Enter Number :");
                int n = Convert.ToInt32(Console.ReadLine());
                // Library class of business Requriment to print
                Console.WriteLine(Algebra.Factorial(n));
                Algebra.Palindrome(n);
            }
            Console.ReadLine();
        }
    }
}
