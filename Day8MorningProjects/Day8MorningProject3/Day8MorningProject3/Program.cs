using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8MorningProject3
{
    internal class Product
    {
        public int Id;
        public string Name;
        public int Price;
        public string Brand;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product(){Id = 41,Name= "iphone", Price=700,Brand="apple" },
                new Product(){Id = 42,Name= " s20", Price = 600,Brand="samsang"},
                new Product(){Id = 43,Name="v10", Price=500 , Brand="vivo"},
                new Product(){Id = 44,Name="oneplus8", Price=400,Brand="oneplus"}
            };

            //for loop
            Console.WriteLine("*********for loop*********");
            for (int i = 0; i < products.Count; i++)
              {
                if (products[i].Price > 500)
                    Console.WriteLine("Name : {0} , Brand : {1}", products[i].Name, products[i].Brand);
               }

            //foreach loop
            Console.WriteLine("*********foreach loop*********");
            foreach(var d in products)
            {
                if (d.Price>500)
                    Console.WriteLine("Name : {0} , Brand : {1}", d.Name, d.Brand);
            }

            //Lambda expression
            Console.WriteLine("*********Lambda expression*********");
            products.Where(p => p.Price > 500).ToList().ForEach(p => Console.WriteLine("Name : {0} , Brand : {1}", p.Name, p.Brand));

            //LinQ query
            Console.WriteLine("*********LinQ query***********");
            var result = from p in products
                         where p.Price > 500
                         select p;
            result.ToList().ForEach(p => Console.WriteLine("Name : {0} , Brand : {1}", p.Name, p.Brand));

            Console.ReadLine();  
        }
    }
}
