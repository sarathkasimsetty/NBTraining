using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
//Write C# program to read two numbers from use and print
//a.sum of two numbers  b. difference of two numbers
// c. product of two numbers  d. division of two numbers.

namespace Day9Morningproject2
{
    internal class Mathstasks
    {
        private int a;
        private int b;

        /// <summary>
        /// /read input from user
        /// </summary>
       public void Readinput()
        {
            Console.WriteLine("Enter the number A");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number B");
            b = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// Adding two numbers of inputs 
        /// </summary>
        /// <returns>Addnumber()</returns>
        public int Addnumber()
        {
            return a + b;
        }
        /// <summary>
        /// difference of two numbers
        /// </summary>
        /// <returns></returns>
        public int Differencenumber()
        {
            return a - b;
        }

        public int Producttwonumber()
        {
            return a * b;
        }

        public float Divisiontwonumber()
        {
            return a / b;
        }

        public int Modulitytwonumber()
        {
            return a % b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
                Mathstasks ans = new Mathstasks();

                ans.Readinput();

            Console.WriteLine("********ADD TWO NUMBER**********");
                Console.WriteLine(ans.Addnumber());

            Console.WriteLine("********** DIFFERENCE TWO NUMBER**********");
                Console.WriteLine(ans.Differencenumber());

            Console.WriteLine("********** PRODUCT TWO NUMBER**********");
            Console.WriteLine(ans.Producttwonumber());

            Console.WriteLine("********** DIVISION TWO NUMBER**********");
            Console.WriteLine(ans.Divisiontwonumber());

            Console.WriteLine("********** MODULITY TWO NUMBER**********");
            Console.WriteLine(ans.Modulitytwonumber());

                Console.ReadLine();
        }
    }
}
