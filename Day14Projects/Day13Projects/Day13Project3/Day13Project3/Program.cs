using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
//Declare a 2-D array of size (3,3) and print trace of the array
namespace Day13Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[3, 3] { { 1, 3, 7 }, { 2, 3, 7 }, { 4, 2, 7 } };
            int sum = 0;

            for(int i =0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    if(i==j) //if same size row and col index is match ex: [0,0],[1,1],[5,5] 
                    {
                        sum = sum + data[i, j];
                    };
                }
            }
            Console.WriteLine("Matrix trace  sum of the array is : {0}",sum);
            Console.ReadLine();
        }
    }
}
