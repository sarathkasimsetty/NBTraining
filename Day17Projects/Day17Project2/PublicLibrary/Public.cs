using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SarathLibrary;
//sarath kasimsetty
// created public library 
namespace PublicLibrary
{
   /// <summary>
   /// mybaseclass from sarathlibrary   
   /// </summary>
    public class MyDerivedClass : MyBaseClass
    {
        public void MyPublicDerivedClassMethod()
        {
            a = 2;
            b = 4;  //Private assess modifier is not accessed in other derived library class 
            c = 6;
            d = 8;  //Internal Access modifier is not accessed in other derived library class 
            e = 10;
        }

    }

    public class MyPublicOtherClass
    {
        public void MyPublicOtherClassMethod()
        {
            MyBaseClass tm = new MyBaseClass();
            /// only public access modifiers is accessed and private,internal,protected,protected internal
            tm.a = 5; 
            tm.b = 6; 
            tm.c = 7;
            tm.d = 8;
            tm.e = 9;
        }

    }
}
