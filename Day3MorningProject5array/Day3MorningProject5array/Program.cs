using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3MorningProject5array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variable declaration
            int sum = 0;
            int[] data = new int[6];
            
            //user input
            for (int i=0; i < data.Length; i++) 

            {
                Console.WriteLine("Enter a Number : ");
                data[i] = Convert.ToInt32(Console.ReadLine());   

            }
            //logical
            for (int i =0; i<data.Length;i++)

            {
                sum = sum + data[i];
            }
            //print output
            Console.WriteLine("sum : {0}", sum); //  sum of the array items
            Console.WriteLine("avg : {0}", sum/data.Length);  // average of the sum

            Console.ReadLine();
        }
    }
}
