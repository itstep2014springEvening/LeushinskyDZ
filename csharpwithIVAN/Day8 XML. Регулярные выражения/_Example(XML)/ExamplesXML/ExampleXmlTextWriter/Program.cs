using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ExampleXmlTextWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запись информации в xml файл с форматированием 

            XmlTextWriter xmlWriter = new XmlTextWriter("books.xml", null)
            {   // Включить форматирование документа (с отступом).
                Formatting = Formatting.Indented, 
                // Для выделения уровня элемента использовать табуляцию.
                IndentChar = '*',
                // использовать 5 символов табуляции.
                Indentation = 3,
                QuoteChar = '\''
            }; 

            xmlWriter.WriteStartDocument();                 // Заголовок XML - <?xml version="1.0"?>

            xmlWriter.WriteStartElement("Books");           
            // формирование элемента с атрибутом
            xmlWriter.WriteStartElement("Book");            // Книга 1 - <Book
            xmlWriter.WriteString("Платформа .NET");       
            xmlWriter.WriteEndElement();                   
            xmlWriter.WriteStartElement("Book");            // Книга 2 - <Book
            xmlWriter.WriteString("Язык C#");               
            xmlWriter.WriteEndElement();                    
            xmlWriter.WriteStartElement("Book");            // Книга 3 - <Book
            xmlWriter.WriteString("ASP.NET");         
            xmlWriter.WriteEndElement();                    
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
