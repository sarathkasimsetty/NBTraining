using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
//Declare a 2 dimentional array of size (2,2) and 
//initialize using indexes and print the values using nested for loop

namespace Day13Project1
{
    /// <summary>
    /// 2D array
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Size is 2 rows and 2 colums
            int[,] data = new int[2, 2];

            data[0, 0] = 6;
            data[0,1] = 8;
            data[1, 0] = 15;
            data[1, 1] = 18;

            for(int i =0;i<2;i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("data[{0}, {1}] = {2} " , i,j, data[i, j]+" ");
                }
                Console.WriteLine("\n");               
            }
            Console.ReadLine();
        }
    }
}
