using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int id = 1;
                string name = "sarath", email = "sarathkasimsetty18@gmail.com";

                Console.WriteLine("ID = {0} , NAME : {1} , EMAIL : {1}", id, name, email);
                
            }
            finally
            {
                Console.WriteLine("\n\n\nThanks & Regards");
                Console.WriteLine("NATIONSBENIFITS");

                Console.ReadLine();
            }

        }
    }
}
