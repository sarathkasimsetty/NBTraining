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
            int input = Convert.ToInt32(Console.ReadLine());

            // new doc instance 
            XmlDocument doc = new XmlDocument();
            doc.Load("F:\\File data\\tagsbased.xml");

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                bool isMatch = false;
                foreach (XmlNode node1 in node.ChildNodes)
                {
                    if (node1.Name == "id")
                    {
                        if (node1.InnerText == input.ToString())
                        {
                            isMatch = true;
                        }
                    }
                    if (node1.Name == "productname" && isMatch)
                    {
                        Console.WriteLine(node1.InnerText);
                        break;
                    }
                }
            }
            Console.ReadLine(); 

        }
    }
}
