using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  fn, sn, sum = 0;
            int p = 1;

            Console.Write("Enter first number:");
            fn = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second number:");
            sn = Convert.ToInt32(Console.ReadLine());

            p = Convert.ToInt32(Math.Pow(fn, sn));

            Console.Write("Power =" + p);

            Console.Read();




        }
    }
}
