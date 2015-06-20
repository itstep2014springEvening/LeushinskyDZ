using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Для использования классов XmlDocument,XmlNodeList,XmlNode

using System.Xml;

namespace ExampleSimpleReadXML
{
    class Program
    {
        static void Main(string[] args)
        {

            XmlDocument doc = new XmlDocument();
            // загрузка XML документа
            doc.Load("books.xml");


            // Показ содержимого XML.
            Console.WriteLine(doc.InnerText);

            Console.WriteLine(new string('-', 20));

            // Показ кода XML документа.
            Console.WriteLine(doc.InnerXml);

            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));
            // получение узлов документа по имени Car
            XmlNodeList nodes = doc.GetElementsByTagName("book");
            // проходим по каждому узлу
            foreach (XmlNode node in nodes)
            {
                // вывод значний узлов Manufactured и Model
                //
                Console.WriteLine("{0}  -  {1}", node["title"].InnerText, node["author"].InnerText);
            }

            // 


            Console.ReadKey();
        }
    }
}
