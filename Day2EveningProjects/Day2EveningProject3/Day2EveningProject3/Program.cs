using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2EveningProject3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, input ;

            Console.WriteLine("Enter Your Number :");
            input = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= input; i++)
                if (input % i == 0)  // if condition those values is true,  that values to print  

                {

                  Console.WriteLine(i);
                }
            Console.ReadLine();

        }
    }

}
