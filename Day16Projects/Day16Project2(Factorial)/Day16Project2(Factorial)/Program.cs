using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
//WACP to read a number from user and print factorial of it.
//Hink: Think object orient

namespace Day16Project2_Factorial_
{
     class Factorial
    {
        int n;
        public void ReadInput()
        {
            Console.WriteLine("Enter any number :");
            n = Convert.ToInt32(Console.ReadLine());
        }
        public int PrintFact()
        {
            int fact = 1;
            for(int i=1;i<=n;i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Factorial num = new Factorial();
            num.ReadInput();

            Console.WriteLine(num.PrintFact());

            Console.ReadLine();

        }
    }
}
