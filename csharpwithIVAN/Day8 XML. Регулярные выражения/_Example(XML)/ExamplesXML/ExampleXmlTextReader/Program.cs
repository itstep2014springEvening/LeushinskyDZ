using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ExampleXmlTextReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 45);
            // открытие файлового потока на файл
            using (FileStream stream = new FileStream("books.xml", FileMode.Open))
            {
                
                XmlTextReader xmlReader = new XmlTextReader(stream);
                // чтение ифнормации из xml файла
                while (xmlReader.Read())
                {
                    Console.WriteLine("{0,-10} {1,-10} {2,-10}",
                                       xmlReader.NodeType,
                                       xmlReader.Name,
                                       xmlReader.Value);
                    Console.WriteLine("------------------------------------");
                }
            }
          
            Console.ReadKey();
        }
    }
}
