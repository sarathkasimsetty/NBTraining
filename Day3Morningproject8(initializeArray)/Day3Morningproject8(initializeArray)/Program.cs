using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Morningproject8_initializeArray_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // initialize an array 
            int sum = 0;
            int[] data = new int[5] { 5, 10, 15, 20, 30 };

            foreach (int i in data)
                sum = sum + i;
            {
                Console.WriteLine(sum);
                
            }
            
            Console.ReadLine();
        }
    }
}
