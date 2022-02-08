using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
//Create Mathematics class and add 3 static methods and call the methods in main method.

namespace Day11Project7
{
    /// <summary>
    /// Static methods
    /// </summary>
    internal class Mathematics
    {
        public static int Add(int a , int b)
        { return a + b; }

        public static int Mul(int a,int b)
        { return a * b; }

        public static int Div(int a, int b)
        { return a / b; }

        public static int Mod(int a ,int b)
        { return a % b; }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****modulity of two numbers******");
            Console.WriteLine(Mathematics.Mod(12, 24));

            Console.WriteLine("*****Adding of two numbers******");
            Console.WriteLine(Mathematics.Add(10, 25));

            Console.WriteLine("*****multiple of two numbers******");
            Console.WriteLine(Mathematics.Mul(10, 5));

            Console.WriteLine("*****modulity of two numbers******");
            Console.WriteLine(Mathematics.Mod(25, 10));

            Console.ReadLine();
        }
    }
}
