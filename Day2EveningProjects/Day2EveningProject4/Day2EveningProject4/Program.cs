using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2EveningProject4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, input;

            Console.WriteLine("Enter Your Number :");
            input = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(input + "x" + i + "=" + input * i); //printing output is using by string concatination
            }
            Console.ReadLine();

            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", input, i, input * i); //printing output is using by string formating
            }
            Console.ReadLine();

        }
    }
}
