using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty

namespace SarathLibrary
{
    //class physics 
    public class Physics
    {
        // method of find finalvelocity
        public int FinalVelocity(int a,int u,int t)
        {
            return u + a * t;
        }
    }
}
