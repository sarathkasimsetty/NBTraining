using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2EveningProject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, input, product = 1;

            Console.WriteLine("Enter your Number :");
            input = Convert.ToInt32(Console.ReadLine());
             
             for(i = 1; i <= input; i++) 

              product = product * i; // 5*4*3*2*1

              Console.WriteLine(product);

              Console.ReadLine();
        }
    }
}
