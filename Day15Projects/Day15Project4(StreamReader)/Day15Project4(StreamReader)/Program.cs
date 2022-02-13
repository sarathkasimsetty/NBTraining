using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
//Research and write C# program to read data from file.

namespace Day15Project4_StreamReader_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // read file by sing streamreader
            StreamReader sr = new StreamReader("F:\\File data\\update.txt");//file path

            
            /*
            string data= sr.ReadToEnd();//Read all character by end of the stream
            Console.WriteLine(data);
            */

            string data = sr.ReadLine();

            while (data != null)
            { 
           
                Console.WriteLine(data);
                data = sr.ReadLine();
            }

            Console.WriteLine("Reading file done");
            Console.ReadLine();
        }
    }
}
