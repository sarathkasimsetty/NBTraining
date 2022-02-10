using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
//print numbers from 1 to 30 and skip the numbers divisible by 3
//HINT : use continue;

namespace Day14Project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=30, i;

            for(i=0;i<=n;i++)
            {
                if (i % 3 == 0)
                    continue; 
  // loop values divisible by 3 condition true ,those number are skip and print remaining numbers
                Console.WriteLine(i);
            }
            Console.ReadLine();
            
        }
    }
}
