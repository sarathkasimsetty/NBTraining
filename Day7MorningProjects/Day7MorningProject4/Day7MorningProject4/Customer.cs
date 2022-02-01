using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7MorningProject4
{
    internal class Customer
    {
        private int customerId;
        private string customerName;
        private string customerEmail;
        private long customerMobileNumber;

        public void ReadCustomerData()
        {
            Console.WriteLine("Enter Customer ID : ");
            customerId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Customer Name : ");
            customerName = Console.ReadLine();

            Console.WriteLine("Enter Customer Subscription Type : ");
            customerEmail = Console.ReadLine();

            Console.WriteLine("Enter Customer Mobile No. : ");
            customerMobileNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\n");
        }
    
            public void DisplayCustomerProfile()
            {
               Console.WriteLine("--------------- Customer Details ---------------");
               Console.WriteLine("customerId : {0}, customerName : {1}, customerEmail : {2}, customerMoblieNumber : {3}",customerId,customerName,customerEmail, customerMobileNumber);

            }
    }
}