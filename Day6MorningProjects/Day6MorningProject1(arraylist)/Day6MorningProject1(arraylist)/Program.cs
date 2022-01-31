using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6MorningProject1_arraylist_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            ArrayList data = new ArrayList();

            data.Add(10);
            data.Add(20);
            data.Add(30);
            data.Add(40);
            data.Add(50);

            foreach(var d in data)
            {
                sum = sum + Convert.ToInt32(d);
            }
            Console.WriteLine("Sum of values of arraylist is : {0} .",sum);
            Console.ReadLine();
        }
    }
}
