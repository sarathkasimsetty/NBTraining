using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//SARATH KASIMSETTY
//Research and write sample code for method overriding virual, override keyword.
namespace Day10MorningProject8
{
    internal class Program
    {
        class Englishmessage
        {
            public virtual void PrintHi()
            {
                Console.WriteLine("HI");
            }
            public virtual void PrintGM()
            {
                Console.WriteLine("GOOD MORNING");
            }
        }
        class Telugumessage : Englishmessage
        {
            public override void PrintGM()
            {
                Console.WriteLine("Namaskaaram");
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
