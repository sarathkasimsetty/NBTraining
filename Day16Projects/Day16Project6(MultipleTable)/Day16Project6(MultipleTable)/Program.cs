using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16Project6_MultipleTable_
{
    class Mathematics
    {
        int input;
        /// <summary>
        /// Read value from user
        /// </summary>
        public void ReadInput()
        {
            Console.WriteLine("Enter any number :");
            input = Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        ///Method of multiple table and print user given value
        /// </summary>
        public void MultipleData()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}",input,i,input* i);
            }   
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mathematics Object
           Mathematics table = new Mathematics();
            table.ReadInput();
            table.MultipleData();

            Console.ReadLine();
        }
    }
}
