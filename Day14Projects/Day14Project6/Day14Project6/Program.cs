using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kadimsetty
//Find the first number after 1000 which is divisible by 97.
//HINT : use for loop and break

namespace Day14Project6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 97, i;

            Console.Write("*********By use loop and break********\n\n");
           // first number after 1000 which is divisible by 97
            for (i=1000;i<1200;i++)
            {
                if (i % n == 0)
                    break;   // if condition is true that loop is stop by using break;
                
            }
            Console.WriteLine(i);

            Console.Write("*********By use loop********\n\n");
            //After numbers of 1000 which is divisible by 97
            for (i = 1000; i < 1200; i++)
            {
                if (i % n == 0)
                { 
                    Console.WriteLine(i);
                }
                    
            }
            

            Console.ReadLine();

        }
    }
}
