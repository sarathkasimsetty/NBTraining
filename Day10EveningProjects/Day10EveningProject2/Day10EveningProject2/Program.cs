using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarth kasimsetty
//Write the 2 main uses of Abstract class by using the example discussed in the class.
namespace Day10EveningProject2
{
    abstract class Salary
    {
        public int GetPF (int basic)
        {
            return 12 * basic / 100;
        }
        public int getHRA (int basic)
        {
            return 40 * basic / 100;
        }

        public abstract int GetCA();
        public abstract int GetSA();
    }

    class Microsoft : Salary
    {
        public override int GetCA()
        {
            return 4000;
        }

        public override int GetSA()
        {
            return 5000;
        }
    }
    class Facebook: Salary
    {
        public override int GetCA()
        {
            return 5000;
        }

        public override int GetSA()
        {
            return 6000;
        }      
    }
    class Google : Salary
    {
        public override int GetCA()
        {
            return 10000;
        }

        public override int GetSA()
        {
            return 10000;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        { 
            Google emp = new Google();
            emp.GetCA();
            emp.GetSA();
            
            Console.WriteLine("completed payment");

            Console.ReadLine();
        }
    }
}
