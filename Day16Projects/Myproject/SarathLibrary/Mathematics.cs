using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
//YourNameLibrary (and add any class with methods)

namespace SarathLibrary
{
    public class Mathematics
    {
        /// <summary>
        /// Find power A and B
        /// </summary>
        /// <param name="a">Base value</param>
        /// <param name="b">Power Value</param>
        /// <returns>aPowerb</returns>
        public static int aPowerb(int a,int b)
        {
            int pow = 1;
            for (int i = 1; i <= b; i++)
                pow = pow * a;
            return pow;
        }

        /// <summary>
        /// Find Factorial of given value
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int Factorial(int a)
        {
            int fact = 1;
            for(int i=1;i<=a;i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        /// <summary>
        /// Adding two numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Add(int a,int b)
        {
            return a + b;
        }
    }
}
