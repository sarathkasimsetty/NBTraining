using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
// WACP to write data into file (and append the data) using Stream writer class.


namespace Day15Project3_streamwriter_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //File.Delete("F:\\File data\\meetdata.txt");

           // Console.WriteLine("File created of MeetingData");

            StreamWriter sw = new StreamWriter("F:\\File data\\meetdata.txt", true);
            //To push line by line to file by using streamwriter
            /*
            sw.WriteLine("Hi");
            sw.WriteLine("I'm sarath");
            sw.WriteLine("I will meet you 28feb 2022");
            sw.WriteLine("Thank you");
            sw.Close();
            
            sw.WriteLine("Hi");
            sw.WriteLine("I am priya");
            sw.WriteLine("I will meet you next week");
            sw.WriteLine("Thank you");
            sw.Close();
            */
            sw.WriteLine("Hello");
            sw.WriteLine("I am siva");
            sw.WriteLine("I will meet you as will as possible");
            sw.WriteLine("Thank you");
            sw.Close();
         

            Console.WriteLine("Done");

            Console.ReadLine();
        }
    }
}
