using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
//Declare a 2-D array of size (2,2) and read values from user
//and print the array values.
namespace Day13Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2D array of size 2 rows and 2 coloum
            int[,] data = new int[2, 2];

            Console.WriteLine("Enter the values of (2x2) side Array");
            for (int i=0;i<2;i++) // i is row 
            {
                for (int j = 0;j<2;j++) // j is coloum
                {
                    Console.Write("data[{0},{1}] = ", i, j);
                    data[i, j] = Convert.ToInt32(Console.ReadLine());
                    //read the value from user
                }
            }

            Console.WriteLine("print the array values gave fron user");
            for (int i = 0; i < 2; i++)
            {
                for(int j=0;j<2;j++)
                {
                    Console.Write("data[{0},{1}] = {2}",i,j,data[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.ReadLine();

        }
    }
}
