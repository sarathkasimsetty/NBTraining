using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
//WACP to declare a jagged array and print values

namespace Day13Project8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring Jagged Array, and initializing.
            char[][] names = new char[3][];

            names[0] = new char[] { 's', 'a', 'r', 'a', 't', 'h' };
            names[1] = new char[] { 's', 'a', 'i' };
            names[2] = new char[] { 'm', 'a', 'n', 'i' };
            
            //printing jagged array values
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<names[i].Length;j++)
                {
                    Console.Write(names[i][j]);
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();

        }
    }
}
