using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty

namespace SarathLibrary
{
    //mybaseclass from sarathlibrary  
    public class MyDerivedClass : MyBaseClass
    {
        public void MyDerivedClassMethod()
        {
            a = 2;
            b = 3; // Private Access modifies is not accessed in derived class  
            c = 4;
            d = 5;
            e = 6;
        }
    }
}
