using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6MorningProject7_lList.string_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> data = new List<string>();
            int i;

            data.Add("ramesh");
            data.Add("suresh");
            data.Add("rakesh");
            data.Add("mahesh");

            //print values using for loop
            for (i = 0;i< data.Count;i++)
            {
              
                Console.WriteLine(data[i]);
            }
            

            // print values by using foreach loop
            foreach (var d in data)
            {
                
                Console.WriteLine(d);

            }

            //print values by using lambda expression


            data.ForEach(p => Console.WriteLine(p)); 

            Console.ReadLine();
            
        }
    }
}
