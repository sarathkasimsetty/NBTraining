using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Project3_ReadXml_
{
    internal class Program
    {
        static void Main(string[] args)
        {   
                XmlDocument doc = new XmlDocument();
                doc.Load("F:\\File data\\Employes.xml");

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                foreach (XmlNode node1 in node.ChildNodes)
                {
                    if (node1.Name == "Id")
                    {
                        Console.Write("{0},", node1.InnerText);
                    }
                    if (node1.Name == "Name")
                    {
                        Console.Write("{0},", node1.InnerText);
                    }
                    if (node1.Name == "Salary")
                    {
                        Console.WriteLine("{0}\n", node1.InnerText);
                    }
                }
            }
            Console.ReadLine();
            
            
        }
    }
}
