using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7MorningProject4
{
    internal class Seller
    {
        private int sellerId;
        private string sellerName;
        private string sellerLocation;
        private string sellerType;

        public void ReadSellerData()
        {
            Console.WriteLine("\nEnter Seller Id : ");
            sellerId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter Seller Name : ");
            sellerName = Console.ReadLine();

            Console.WriteLine("\nEnter Seller Location : ");
            sellerLocation = Console.ReadLine();

            Console.WriteLine("\nEnter Seller Type : ");
            sellerType = Console.ReadLine();
            Console.WriteLine("\n");
        }
        public void DisplaySellerData()
        {
            Console.WriteLine("\n--------------- Seller Details ---------------\n");
            Console.WriteLine($"\n\tSeller Id : {sellerId}\n\tSeller Name : {sellerName}" +
                $"\n\tSeller Location : {sellerLocation}\n\tSeller Type : {sellerType}");
        }    
    }
}
