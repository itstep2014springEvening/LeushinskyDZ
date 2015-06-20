using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"http://informer.gismeteo.by/rss/26850.xml";
            StringBuilder mb = new StringBuilder();
            Console.WriteLine("WeatherBrowser v1.0");
            Console.WriteLine("Choose city: ");
            Console.WriteLine("1. Minsk");
            Console.WriteLine("2. Kiev");
            Console.WriteLine("3. Riga\n");

            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNodeList nlist = doc.GetElementsByTagName("item");
            int i = 0;
            foreach (XmlNode xitems in nlist)
            {
               // var childnodes = xitems.ChildNodes;
                if (xitems.ChildNodes[i].Name == "title" /*|| childnodes[i].Name == "description"*/)
                {
                    mb.Append(xitems.ChildNodes[i].InnerText + Environment.NewLine);
                }
                if (xitems.ChildNodes[i].Name == "description" /*|| childnodes[i].Name == "description"*/)
                {
                    mb.Append(xitems.ChildNodes[i].InnerText + Environment.NewLine + Environment.NewLine);
                }
                i++;
            }

            
            //foreach (XmlNode xn in nlist)
            //{
            //    Console.WriteLine(nlist[i].InnerText);
            //    i++;
            //}


            Console.WriteLine(mb);
           
            Console.Read();
            
        }
    }
}
