using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///product of two matrices(size[2,2]) from read value from user.
            int[,] array1 = new int[2, 2];
            int[,] array2 = new int[2, 2];
            int[,] product = new int[2, 2];

            Console.Write("Input elements in the first matrix :\n");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("index[{0},{1}] =", i, j);
                    array1[i, j] = Convert.ToInt32(Console.ReadLine());
                    //values are read from user
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    //print first matrix from user given values 
                    Console.Write(array1[i, j] + " ");
                }
                Console.WriteLine("\n");
            }

            Console.Write("Input elements in the second matrix :\n");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("index[{0},{1}] =", i, j);
                    array2[i, j] = Convert.ToInt32(Console.ReadLine());
                    //values are read from user
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(array2[i, j] + " ");
                    ////print second matrix from user given values
                }
                Console.WriteLine("\n");
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    //product of the first matrix and second matrix
                    product[i, j] = array1[i, j] * array2[i, j];
                }
            }

            Console.Write("product of the two matrix :\n");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(product[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
