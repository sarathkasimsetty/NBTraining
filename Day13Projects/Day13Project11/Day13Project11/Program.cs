using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//srath kasimsetty
//WACP to illustrate usage of Stack<>
//Write couple of points about Stack

namespace Day13Project11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> data = new Stack<int>();
            data.Push(15);
            data.Push(21);
            data.Push(10);

            Console.WriteLine(data.Count());
            Console.WriteLine(data.Peek());
            Console.WriteLine(data.Count());
            Console.WriteLine(data.Pop());
            Console.WriteLine(data.Count());

            Console.ReadLine();
        }
    }
}
// 1) Helps you to manage the data in a Last In First Out method which is not
//    possible with Linked list and array so , by using Stack generics.
// 2) Stack is useful to store temporary data in (Last In First Out) , and you might want to
//    delete an element after retrieving its value. 
// 3) pop is remove the element and count vlaue also remove.
// 4) peek is only remove temporary valve of element.

