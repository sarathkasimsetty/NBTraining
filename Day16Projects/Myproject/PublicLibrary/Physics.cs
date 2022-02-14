using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
//PublicLibrary (add any class with methods)

namespace PublicLibrary
{
    public class Physics
    {
        /// <summary>
        /// Find Velocity of given values
        /// </summary>
        /// <param name="u"></param>
        /// <param name="a"></param>
        /// <param name="t">time</param>
        /// <returns>FindVelocity</returns>
        public static int FindVelocity(int u, int a, int t)
        {
            return u + a * t;
        }
    }
}
