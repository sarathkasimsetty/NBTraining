using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Similar to 6 and 7 projects create list of Customer an Product Arrays
//and practice for, foreach and lambda expression
namespace Day7MorningProject8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer[] Customers = new Customer[]
            {
            new Customer(){Id = 1 ,name = "sarath" , email = "586@mail.com"},
            new Customer(){Id = 2 ,name = "ravi"  , email = "255@gmail.com"},
            new Customer(){Id = 3 ,name = "sai" ,email = "599@gmail.com" }
            };

            Product[] products = new Product[]
            {
              
                new Product(){Id = 1 , Name="footwear", Price= 4522},
                new Product(){Id = 2 , Name="footwear", Price= 5487},
                new Product(){Id = 3 , Name="footwear", Price= 458},
                new Product(){Id = 4 , Name="footwear", Price= 457},
                new Product(){Id = 5 , Name="footwear", Price= 478}
            };
            Console.WriteLine("**************************class.customer***********************");
            Console.WriteLine("*********ForLoop********");
            //for loop
            for (int i=0; i < Customers.Length ;i++ ) 
            {
                Console.WriteLine("Id = {0} , CustomerName = {1} email = {2}", Customers[i].Id, Customers[i].name, Customers[i].email);

            }

            Console.WriteLine("*************foreach**********");
            //foreach loop
            foreach(var d in Customers)
            {
                Console.WriteLine("Id = {0} , CustomerName = {1} , CustomerEmail = {2}",d.Id,d.name,d.email);
            }

            Console.WriteLine("***********lambda expression**************");
            //Lambda Expression
            Customers.ToList().ForEach(d => Console.WriteLine("Id = {0} , CustomreName = {1} , CustomerEmail = {2}", d.Id, d.name, d.email));

            Console.WriteLine("***********************class.Product*******************************");
            Console.WriteLine("*************foreach**********");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Id = {0} , ProductName = {1} ProductPrice = {2}", products[i].Id, products[i].Name, products[i].Price);

            }
            Console.WriteLine("*************foreach  loop**********");
            //foreach loop
            foreach (var d in products)
            {
                Console.WriteLine("Id = {0} , ProductName = {1} , productPrice = {2}", d.Id, d.Name, d.Price);
            }

            Console.WriteLine("***********lambda expression**************");
            //Lambda Expression
            products.ToList().ForEach(d => Console.WriteLine("Id = {0} , ProductName = {1} , ProductPrice = {2}", d.Id, d.Name, d.Price));

            Console.ReadLine();
        }
    }
}
