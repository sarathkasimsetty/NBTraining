using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
//Write example code for:
//a.Single inheritance b. Multi level inheritance
namespace Day10MorningProject2
{
    /// <summary>
    /// Multilevel inheritance
    /// </summary>
    internal class Week1
    {
        public int a;
        public int b;
        /// <summary>
        /// read input from input
        /// </summary>
        public void Readinput()
        {
            Console.WriteLine("Enter a Value A");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a value B");
            b = Convert.ToInt32(Console.ReadLine());
        }
        public int Add()
        {
            return a + b;
        }
        public int Sub()
        {
            return a - b;
        }
    }
    /// <summary>
    /// week1 is parent class and week2 is chils class
    /// </summary>
    class Week2 :Week1
    {
        
        public int product()
        {
            return a * b;
        }
        public int Modulity()
        {
            return a % b;
        }
    }
    /// <summary>
    /// week3 is child class and week2 is parent class
    /// </summary>
    class Week3 : Week2
    {
        /// <summary>
        /// FULL FORM OF OOPS
        /// </summary>
        /// <returns>Oops</returns>
        public string Oops()
        {
            return "object oriented programming";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Week3 sol = new Week3();
            
            sol.Readinput();
            Console.WriteLine("*********Add two Numbers********");
            Console.WriteLine(sol.Add());

            Console.WriteLine("*********Modulity two Number*********");
            Console.WriteLine(sol.Modulity());

            Console.WriteLine("*********Subtraction two Numbers********");
            Console.WriteLine(sol.Sub());

            Console.WriteLine("**** Fullform of OOPS*******");
                Console.WriteLine(sol.Oops());

            Console.ReadLine();
        }
    }
}
