using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarathLibrary
{
    public class MyBaseClass
    {
        public int a;
        private int b;
        protected int c;
        internal int d;
        protected internal int e; 

        public void MyBaseClassMethod()
        { 
            a = 1;
            b = 2;
            c = 3;
            d = 4;
            e = 5;
            // base class accessed all access modifiers
        }
    }
   
}
