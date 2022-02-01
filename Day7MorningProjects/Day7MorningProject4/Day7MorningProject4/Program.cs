using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// sarath kasimsetty
// Purpose : Creating an 4 different Class with Required 2 Methods(ReadingData & PrintData) & Calling the methods.

namespace Day7MorningProject4
{
    internal class Program
    {
        // Customer Class
        // Products Class
        // Seller Class
      
        static void Main(string[] args)
        {
            // Customer Instance
            Customer customer1 = new Customer();
            Console.WriteLine("Enter Customer Details : ");
            customer1.ReadCustomerData();

            // Products Instance
            Products product1 = new Products();
            Console.WriteLine("Enter Product Details : ");
            product1.ReadProductData();

            // Seller instance
            Seller sell1 = new Seller();
            Console.WriteLine("Enter Seller Details : ");
            sell1.ReadSellerData();

            customer1.DisplayCustomerProfile();

            product1.DisplayProducts();

            sell1.DisplaySellerData();

            Console.WriteLine("\n--------------------- The End------------------------------------");

            Console.ReadLine();
        }
    }
}
