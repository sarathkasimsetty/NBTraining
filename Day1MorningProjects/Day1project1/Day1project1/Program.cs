using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fn , sn , sum;

            Console.Write("Enter first number:");
            fn = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number:");
            sn = Convert.ToInt32(Console.ReadLine());

            sum = fn + sn;

            Console.Write("sum = " + sum);

            Console.ReadLine();
        }
    }
}
