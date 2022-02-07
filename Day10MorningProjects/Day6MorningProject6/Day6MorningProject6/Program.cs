using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
//Write sample code for method overloading
namespace Day6MorningProject6
{
    internal class Program
    {
        /// <summary>
        /// overloading in polymorphism
        /// </summary>
        internal class Mathstask
        {
            public int Add(int a,int b )
            {
                return a + b;
            }
            public int Add(int a,int b,int c)
            {
                return a + b + c;
            }
            /// <summary>
            /// this is method is same but parameter are difference
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <param name="c"></param>
            /// <param name="d"></param>
            /// <returns>Add</returns>
            public int Add(int a ,int b ,int c,int d) { return a + b + c + d; }
        }
        static void Main(string[] args)
        {
            Mathstask obj = new Mathstask();

            Console.WriteLine("******Adding four numbers*******");
            Console.WriteLine(obj.Add(25, 10,5,5));

            Console.ReadLine();

        }
    }
}
