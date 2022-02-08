using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//SARATH KASIMSETTY
//Write a simple division program and handle three exceptions discussed in the class., also add super exception at the last.

namespace Day12Project2
{
    /// <summary>
    /// Exception handling
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] data = new string[5];
                data[4] = "sarath";

                int a, b, c, d;

                Console.WriteLine("Enter First Number : ");
                a = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter Second Number : ");
                b = Convert.ToInt32(Console.ReadLine());
                
                c = a + b;  //adding two variable a and b
                d = a / b;  //division two variable a and b

                Console.WriteLine("Answer of adding = {0}", c);
                Console.WriteLine("Answer of division = {0}", d);              
            }

            catch(System.DivideByZeroException)
            {
                Console.WriteLine("cannot division by number 0");
            }
            catch(System.OverflowException)
            {
                Console.WriteLine("Only numbers are between 0 to 500000");
            }
            
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Array range is 5 only so not suppose you given range");
            }
            catch (Exception)
            {
                Console.WriteLine("Any some technical issue to contact the sarathkasimsetty18@gmail.com");
            }
            finally
            {
                Console.WriteLine("\n\n\n\n\n\nDeveloper by SARATH");
                Console.ReadLine();
            }
        }
    }
}
