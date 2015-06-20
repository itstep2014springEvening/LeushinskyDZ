using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ExampleXmlTextWriter1
{
    class Program
    {
        static void Main(string[] args)
        {
            // формирование xml-файла:
            // запись элементов и атрибутов!
            XmlTextWriter xmlWriter = new XmlTextWriter("books.xml",Encoding.Default);

            xmlWriter.WriteStartDocument();                 // Заголовок XML - <?xml version="1.0"?>
           
            xmlWriter.WriteStartElement("Books");           // Корневой элемент - <Books>
            // формирование элемента с атрибутом
            xmlWriter.WriteStartElement("Book");            // Книга 1 - <Book
            xmlWriter.WriteStartAttribute("Rating");        // Атрибут - Rating
            xmlWriter.WriteString("10+");
            xmlWriter.WriteEndAttribute();                   // >
            xmlWriter.WriteString("Платформа .NET");         // Платформа .NET
            xmlWriter.WriteEndElement();                     // </Book>
            
            xmlWriter.WriteStartElement("Book");             //  <Book>
            xmlWriter.WriteString("Язык C#");                //  Язык C#
            xmlWriter.WriteEndElement();                     //  </Book>
           
            xmlWriter.WriteStartElement("Book");             //  <Book>
            xmlWriter.WriteString("ASP.NET");                //  ASP.NET
            xmlWriter.WriteEndElement();                     //  </Book>   
            xmlWriter.WriteComment("Строка комментария.");
            xmlWriter.WriteEndElement();                     // </Books>          

            xmlWriter.Close();

            // чтение созданного xml-файла
            XmlDocument doc = new XmlDocument();
            doc.Load("books.xml");
            Console.WriteLine(doc.InnerXml);

            Console.ReadKey();
        }
    }
}
