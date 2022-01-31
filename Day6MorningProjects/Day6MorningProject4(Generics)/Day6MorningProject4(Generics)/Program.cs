using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6MorningProject4_Generics_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<int> data = new List<int>();
            int i, sum = 0, sum1 = 0;

            data.Add(5);
            data.Add(10);
            data.Add(20);
            data.Add(40);
            data.Add(80);

            for (i = 0; i < data.Count; i++)
                sum = sum + data[i];
            {
                Console.WriteLine("sum of the values by using for loop is: {0}",sum); 
            }

            foreach (var d in data)
                sum1 = sum1 + d;
            Console.WriteLine("sum of the values by using foreach loop is: {0}",sum1);

            Console.ReadLine();
        }
    }
}
