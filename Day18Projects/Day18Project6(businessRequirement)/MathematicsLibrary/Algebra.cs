using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
//create a layered architecture
//project with seperate class library for Business logic.

namespace MathematicsLibrary
{
    public  class Algebra
    { 
        /// <summary>
        /// Business Requriment
        /// </summary>
        /// <param name="n">Factorial Number</param>
        /// <returns>Factorial</returns>
        public static int Factorial(int n)  
        {
            int fact = 1;
            if (n == 0)
                return 1;

            else if (n > 7)
                return -999;
            else if (n < 0)
                return -9999;
            else
            {
                for (int i = 1; i <= n; i++)
                    fact = fact * i;
                return fact;
            }

        }
        public static int Palindrome(int n)
        {
            int m, rem, rev = 0;
            m = n;
            while (m > 0)
            {
                rem = m % 10;
                m = m / 10;
                rev = rev * 10 + rem;
            }
            if (rev == n)
                return rev;
            else
                return rev; 
            
        }
         
    }
}
