using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClient.ServiceReference1;

namespace MyClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlgebraSoapClient obj = new AlgebraSoapClient();

            Console.WriteLine("Factorial of 5 is : {0}",obj.Factorial(5));
            Console.WriteLine("Adding of two number 15 and 10 : {0}",obj.Add(15, 10));
            Console.ReadLine();
        }
    }
}
