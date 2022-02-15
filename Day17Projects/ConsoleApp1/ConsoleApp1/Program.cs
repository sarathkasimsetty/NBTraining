using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        class Cocacola
        {
            // variables
            public string brand;
            public string quantity;
            public int price;
            
        }
        static void Main(string[] args)
        {
            // created one object
            Cocacola item1 = new Cocacola() { brand = "Thumsup", quantity = "1 Litre", price = 50 };
            //created another object
            Cocacola item2 = new Cocacola() { brand = "Maaza", quantity = "1 Litre", price = 65 };

            Console.WriteLine("Name: {0}, Quantity: {1}, Price: {2}",item1.brand,item1.quantity,item1.price);
            Console.WriteLine("Name: {0}, Quantity: {1}, Price: {2}", item2.brand, item2.quantity, item2.price);
            Console.ReadLine();
        }
    }
}
