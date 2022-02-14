using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
//WACP to print Hello World
//Hint: Think object oriented

namespace Day16Project1_Hello_
{
    internal class Message
    {
        //static method
        public static void Printdata()
        {
             Console.WriteLine("Hello");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Message.Printdata();//Print hello from static method

            Console.ReadLine();
        }
    }
}
