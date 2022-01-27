using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3MorningProject7foreacharray
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int sum = 0;
            int[] data = new int[4];

            for (int i = 0; i<data.Length;i++)
            {
                Console.WriteLine("Enter nunber:");
                data[i] = Convert.ToInt32(Console.ReadLine());


            }

            foreach (int i in data)
            {
               
                Console.WriteLine(i);
               
            }

            Console.ReadLine();
        }
    }
}
