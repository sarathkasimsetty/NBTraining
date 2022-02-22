using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
//WACP to illustrate usage of Recursion.

namespace Day13Project10
{
    internal class Program
    {
        static void PrintOutput(int a)
        {
            Console.WriteLine("Factorial of {0} is {1} ", a, Factorial(a));
        }
        static int Factorial(int a) //Function parameter
        {
            if (a == 0)
                return 1;
            else
                return a * Factorial(a - 1);
        }
        static void Main(string[] args)
        {
            int num1,num2;
            //read values from user
            Console.WriteLine("Enter any number to find fatorial : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter any number to find fatorial : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            //print output from funtion return
            PrintOutput(num1);
            PrintOutput(num2);

            Console.ReadLine();
        }
    }
}
