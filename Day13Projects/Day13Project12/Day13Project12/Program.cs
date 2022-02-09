using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sarath kasimsetty
//WACP to illustrate usage of Queue<>
//Write couple of points about Stack

namespace Day13Project12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> data = new Queue<int>();

            data.Enqueue(19);
            data.Enqueue(15);
            data.Enqueue(14);
            data.Enqueue(10);
            Console.WriteLine(data.Count());
            Console.WriteLine(data.Peek());
            Console.WriteLine(data.Count());
            Console.WriteLine(data.Dequeue());
            Console.WriteLine(data.Count());

            Console.ReadLine();
        }
    }
}
// 1) Queue is a Special type of collection that stores elements in (First In
//    First Out).
// 2) peek is the temporary element and return that the element
//    will be first.
// 3) DeQueue is the remove the element and also count is remove.
