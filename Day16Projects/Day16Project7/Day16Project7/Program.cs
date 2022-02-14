using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
// WACP to check if the given is number is Palindrome or not

namespace Day16Project7
{
    class Maths //class name Maths
    {

        int  m, input, rem, rev = 0;
        /// <summary>
        /// Read value from user
        /// </summary>
        public void ReadInput()
        {
            Console.WriteLine("Enter any Number :");
            input=Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// It method of check it is number is Palindrome or NOT
        /// </summary>
        public void PalindromeValue()
        {
            m = input;
            while(m>0)
            {
                rem = m % 10;
                m = m / 10;
                rev = rev * 10 + rem;
            }
            if (rev == input)
            {
                Console.WriteLine("{0}  is a Palindrome Number",input);
            }
            else
                Console.WriteLine("{0} is a NOT Palindrome Number", input);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Maths num =new Maths();
            Console.WriteLine("************Check it is Palindrome or not*************");
            num.ReadInput();
            num.PalindromeValue();

            Console.ReadLine();
        }
    }
}
