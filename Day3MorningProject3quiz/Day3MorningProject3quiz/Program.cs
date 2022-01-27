using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3MorningProject3quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ans, score = 0;
            string name ;
            char enter  ,i = 'y';

            Console.WriteLine("Enter you Name: ");
            name = Console.ReadLine();

            Console.WriteLine("*********************************************");
            Console.WriteLine("Hello {0} ,Welcome to quiz by Sarath", name);
            Console.WriteLine("*********************************************");

            Console.WriteLine("Are you ready for quiz {0},Enter a 'y' or 'n' ?",name);
            enter = Convert.ToChar(Console.ReadLine());

            if ( enter == 'y')
            {


                Console.WriteLine("Q1. How many states in India?");
                Console.WriteLine("1. 28      2. 26      3. 18     4. 29");
                Console.WriteLine("select your options:");
                ans = Convert.ToInt32(Console.ReadLine());

                if (ans == 1)
                    score += 20;

                Console.WriteLine("Q2. Who is the father of our nation?");
                Console.WriteLine("1. jawaharlal nehru    2. mahatma gandhi    3. subhas chandhra bose ");
                Console.WriteLine("select your options:");
                ans = Convert.ToInt32(Console.ReadLine());

                if (ans == 2)
                    score += 20;


                Console.WriteLine("Q3. Fastest animal on earth is?");
                Console.WriteLine("1. camel    2. lion    3. snake    4. cheetah");
                Console.WriteLine("select your options:");
                ans = Convert.ToInt32(Console.ReadLine());


                if (ans == 4)
                    score += 20;


                Console.WriteLine("Q4. What is size of the 1GB ?");
                Console.WriteLine("1. 1024KB    2. 500MB    3. 1024MB     4. 1024GB");
                Console.WriteLine("select your options:");
                ans = Convert.ToInt32(Console.ReadLine());


                if (ans == 3)
                    score += 20;

                Console.WriteLine("Q5. How many players are there in a cricket team?");
                Console.WriteLine("1. 7    2. 10    3. 18    4. 11 ");
                Console.WriteLine("select your options:");
                ans = Convert.ToInt32(Console.ReadLine());

                if (ans == 4)
                    score += 20;

                if (score >= 60)
                    Console.WriteLine("Congratulation {0}, you got {1}% in this quiz", name, score);
                else
                    Console.WriteLine("Sorry {0}, you got {1}% in this quiz. Try again{0}", name, score);


                Console.ReadLine();
            }














        }
    }
}
