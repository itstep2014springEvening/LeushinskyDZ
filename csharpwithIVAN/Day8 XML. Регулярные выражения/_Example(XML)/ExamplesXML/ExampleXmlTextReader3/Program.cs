using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ExampleXmlTextReader3
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlTextReader reader = new XmlTextReader("books.xml");
            // чтение атрибутов!
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    // Проверка на тип узла необходима, иначе будут найдены 
                    // не только открывающие элементы (XmlNodeType.Element),
                    // но и закрывающие (XmlNodeType.EndElement).
                    if (reader.Name.Equals("title"))   
                    {
                        Console.WriteLine("<{0}>", reader.GetAttribute("lang"));
                    }
                }
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
