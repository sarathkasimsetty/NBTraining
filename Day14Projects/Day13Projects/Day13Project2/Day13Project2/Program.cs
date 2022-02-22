using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
//Declare a 2-D array of size (3,2) and
//initialize in the same line while declaring and print the valuesusing nested for loop

namespace Day13Project2
{
    //2D Array
    internal class Program
    {
        static void Main(string[] args)
        {
            ///size of rows is 3 and colums is 2
            int[,] data = new int[3, 2] { { 2, 5 },{ 5, 8 },{ 5, 9 } };

            for(int i =0;i<3;i++)// i is rows
            {
                for (int j=0;j<2;j++) // j is cols
                {
                    //print the values step by step using loop
                    Console.Write("data[{0},{1}] = {2}",i,j, data[i, j] + " "); 
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
