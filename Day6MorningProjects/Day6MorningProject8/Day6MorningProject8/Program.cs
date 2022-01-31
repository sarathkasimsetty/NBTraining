using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// to declare list<int> and read the values from user and find the sum using
namespace Day6MorningProject8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();
            int temp;
            int sum1 = 0, sum2 = 0, sum3 = 0;

            //read values from user
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Enter any value :");
                temp = Convert.ToInt32(Console.ReadLine());
                data.Add(temp);
            }

            //find sum using for loop
            for (int i = 0; i < data.Count; i++)
                sum1 = sum1 + data[i];
                Console.WriteLine(sum1);
            

            //find sum of values by using foreach loop

            foreach (var d in data)
        
                sum2 = sum2 + d;
            Console.WriteLine(sum2);
        

            //find sum of values by using lambda expression

            data.ForEach(d => sum3 = sum3 + d);
            Console.WriteLine(sum3);

            Console.ReadLine();
        }
    }
}
