using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
//Write a C# program to read input from user and print
//a.factorial of a number b. factors of a numberc. check if it prime or not
namespace Day9MoningProject
{
    internal class MathsOperations
    {
        private int input;

        public void Readinput()
        {
            Console.WriteLine("enter any number : ");
            input = Convert.ToInt32(Console.ReadLine());
        }

        public void Factorial()
        {
            int fact = 1;
            for (int i = 1; i <= input; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);           
        }

        public void Factors()
        {
            for (int i = 1 ; i <= input; i++) 
            {
                if (input%i == 0)
                    Console.WriteLine(i); 
            }
        }
        public bool Isprime()
        {
            int count = 0;
            for(int i=1;i<=input;i++)
            {
                if (input % i == 0)
                    count++;
            }
            if (count == 2)
                return true;
            else
                 return false;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MathsOperations mat = new MathsOperations();
            mat.Readinput();
            Console.WriteLine("*********factorial of input********");
            mat.Factorial();
            Console.WriteLine("*********factors of input********");
            mat.Factors();
            Console.WriteLine("*********Prime or Not Prime of input********");
            mat.Isprime();
            if (mat.Isprime())
                Console.WriteLine("input is Prime Number ");
            else
                Console.WriteLine("input is not prime number");

            Console.ReadLine();
        }
    }
}
