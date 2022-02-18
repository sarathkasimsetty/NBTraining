using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Project2_ReadNames_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("F:\\File data\\Employes.xml");

            foreach(XmlNode node in doc.DocumentElement.ChildNodes)
            {
                foreach(XmlNode node1 in node.ChildNodes)
                {
                    if(node1.Name=="Name")
                    {
                        Console.WriteLine(node1.InnerText);
                    }
                }
            }
            Console.Read();
            /*
            using (XmlReader reader = XmlReader.Create(@"F:\File data\Employes.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        //return only when you have START tag  
                        switch (reader.Name.ToString())
                        {
                            case "Name":
                                Console.WriteLine( reader.ReadString());
                                break;         
                        }
                    }                 
                }
            }
            */

        }
    }
}
