using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
//Create a Class Library Project with name as < YourName > Library
//Create a class Mathematics as discussed in the class.

namespace SarathLibrary
{
    public class Mathematics
    {
        int n;
        //read value from user
        public void ReadInput()
        {
            Console.WriteLine("Enter any number");
            n = Convert.ToInt32(Console.ReadLine());
        }
        // factorial of given number
        public int GetFactorial()
        {
            int fact = 1;
            for(int i=1;i<=n;i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
