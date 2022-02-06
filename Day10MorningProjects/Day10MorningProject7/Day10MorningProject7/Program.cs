using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
//Write sample code for method overriding[ using new key word ]
namespace Day10MorningProject7
{
    internal class Program
    {
        class Englishmessage
        {
            public void PrintHi()
            {
                Console.WriteLine("HI");
            }
            public void Printsarath()
            {
                Console.WriteLine("sarath");
            }
            public void PrintGM()
            {
                Console.WriteLine("GOOD MORNING");
            }
        }
        class Telugumessage : Englishmessage
        { 
            public new void PrintGM()
            {
                Console.WriteLine("Subhodayam");
            }
        }
        static void Main(string[] args)
        {
            Telugumessage msg = new Telugumessage();

            msg.PrintGM();

            Console.ReadLine();

        }
    }
}
