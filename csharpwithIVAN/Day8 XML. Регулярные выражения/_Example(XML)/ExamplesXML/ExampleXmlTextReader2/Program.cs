using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ExampleXmlTextReader2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 30);
          
                XmlTextReader reader = new XmlTextReader("books.xml");

                // Поэлементное чтение XML файла.
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        reader.Read(); // Читаем содержимое узла.
                        Console.WriteLine("{0}:{1}", reader.NodeType, reader.Value);
                    }
                    else
                    {
                        Console.WriteLine("{0}", reader.NodeType);
                    }
                }

            Console.ReadKey();
        }
    }
}
