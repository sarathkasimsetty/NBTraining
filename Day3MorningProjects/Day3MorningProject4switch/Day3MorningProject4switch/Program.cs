using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3MorningProject4switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            char letter;

            Console.WriteLine("Enter the character of letters");
            letter = Convert.ToChar(Console.ReadLine());

            switch(letter)
            {
                case 'a':
                    Console.WriteLine("vowel");
                    break;

                case 'e':
                    Console.WriteLine("vowel");
                    break;

                case 'i':
                    Console.WriteLine("vowel");
                    break;

                case 'o':
                    Console.WriteLine("vowel");
                    break;

                case 'u':
                    Console.WriteLine("vowel");
                    break;

                 default:
                    Console.WriteLine("not vowel");
                    break;

                  


            }


                Console.ReadLine();


        }
    }
}
