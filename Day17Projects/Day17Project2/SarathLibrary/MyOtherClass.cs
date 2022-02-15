using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarathLibrary
{
    /// <summary>
    /// from sarath library create object of MyBaseClass
    /// </summary>
    internal class MyOtherClass
    {
        public void MyOtherClassMethod()
        {
            MyBaseClass num = new MyBaseClass();

            num.a = 5;
            num.b = 10; //Private access modifiers is  not accessed in other class method
            num.c = 20; //Protected access modifiers is  not accessed in other class method
            num.d = 30;
            num.e = 40;

        }
         
    }
}
