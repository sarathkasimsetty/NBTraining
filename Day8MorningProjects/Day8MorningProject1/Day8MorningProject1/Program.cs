using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
//Declare and initialize a list with 8 values.write for loop, foreach loop, lambda, linq query
// to print even numbers
namespace Day8MorningProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data= new List<int>() { 12, 45, 88, 77, 66, 75, 56, 11};

            //for loop
            Console.WriteLine("**********For loop*********");
            for (int i = 0; i < data.Count; i++) 
            {
                if (data[i] % 2 == 0)
                    Console.WriteLine(data[i]);
            }

            //foreach loop
            Console.WriteLine("*********Foreach loop********");
            foreach(var d in data)
            {
                if (d % 2 == 0)
                    Console.WriteLine(d);
            }

            //Lambda expression
            Console.WriteLine("*********Lambda Expression******");
            data.ToList().Where(d => d % 2 == 0).ToList().ForEach(d=>Console.WriteLine(d));

            //LinQ query
            Console.WriteLine("**********LinQ query**********");
            var result = from d in data
                         where d % 2 == 0
                         select d;
            result.ToList().ForEach(d=>Console.WriteLine(d));

            Console.ReadLine();

        }
    }
}
