using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
//WACP to check if the number is prime or not using logic discussed in the class
//HINT : use break;

namespace Day14Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            //read value from user
            Console.WriteLine("Enter any number : ");
            n = Convert.ToInt32(Console.ReadLine());

            //logical
            for(i =2;i<=n;i++)
            {
                if (n % i == 0)
                    break;
            }
            if (n == i) // user value and loop value will be same its prime
                Console.WriteLine("{0} IS PRIME",n);
            else // If case loop is not satisfied it eill be break
                Console.WriteLine("{0} IS NOT PRIME",n);
                

            Console.ReadLine();
        }
    }
}
