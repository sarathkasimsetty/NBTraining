using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2EveningProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, input ,sum = 0;

            Console.WriteLine("Enter Your Number :");
            input = Convert.ToInt32(Console.ReadLine());

            for(i=1; i<=input; i++)
            
             sum = sum + i;
             Console.WriteLine(sum);
            

             Console.ReadLine();
        }

    }
}
