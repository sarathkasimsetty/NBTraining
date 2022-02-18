using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace Project4_ReadInputToPrint_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the ID of the file");
            int input = int.Parse(Console.ReadLine());

            // new doc instance 
            XmlDocument doc = new XmlDocument();
            doc.Load("F:\\File data\\attributebased.xml");

            //load up the xml from the location 


            var products = doc.GetElementsByTagName("products")[input-1].Attributes["productname"].Value;
            Console.WriteLine(products);
            /*
            XmlDocument doc = new XmlDocument();
            doc.Load(@"D:\C#\GitHub\Day19Project4\AttributeBasedXML.xml");
            var Mobile = doc.GetElementsByTagName("Mobile")[input - 1].Attributes["Name"].Value;
            Console.WriteLine(Mobile);*/
            Console.ReadLine();
        }
    }
}
