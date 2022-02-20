using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty

namespace Project3_Nullable_
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            int? bal_numA= null;
            int? bal_numB = 200;
            Console.WriteLine(bal_numA.GetValueOrDefault()+bal_numB.GetValueOrDefault());
            Console.ReadLine();*/

            int? input = null;
            int b = 5;
            if (input.HasValue)
            {
                Console.WriteLine(input * b);
            }
            else if (input.HasValue)
                Console.WriteLine("input is null");
            else
            {
                int output = input ?? 2;

                Console.WriteLine(output);
            }
            Console.ReadLine();
        }
    }
}
