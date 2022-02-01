using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7MorningProject4
{
    internal class Products
    {
        private int productID;
        private string productName;
        private string productBrand;
        private long productPrice;

        public void ReadProductData()
        {
            Console.WriteLine("Enter the Product ID : ");
            productID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Product Name : ");
            productName = Console.ReadLine();

            Console.WriteLine("Enter the Product Brand : ");
            productBrand = Console.ReadLine();

            Console.WriteLine("Enter the Product Price : ");
            productPrice = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\n");
        }

        public void DisplayProducts()
        {
            Console.WriteLine("\n--------------- Product Details ---------------\n");
            Console.WriteLine($"\n\tProduct Id : {productID}\n\tProduct Name : {productName}" +
                $"\n\tProduct Brand : {productBrand}\n\tProduct Price : {productPrice}");
        }
    }

}
