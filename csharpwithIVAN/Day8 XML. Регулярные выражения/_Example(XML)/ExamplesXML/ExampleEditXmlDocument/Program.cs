using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ExampleEditXmlDocument
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                // разбирает XML  и  строит его представление в памяти
                doc.Load("books.xml");
                // получение корневого элемента
                XmlNode root = doc.DocumentElement; 
               
                // удаление дочернего элемента   (1-го дочернего)
                root.RemoveChild(root.FirstChild);
               
               
                // создание нового элемента
                XmlNode newPaper = doc.CreateElement("NewPaper");

                XmlNode elem1 = doc.CreateElement("title");
                XmlNode elem2 = doc.CreateElement("autor");
                XmlNode elem3 = doc.CreateElement("pages");
                XmlNode elem4 = doc.CreateElement("price");

                XmlNode text1 = doc.CreateTextNode("С# 6.0");
                XmlNode text2 = doc.CreateTextNode("Ivanov I.I.");
                XmlNode text3 = doc.CreateTextNode("10");
                XmlNode text4 = doc.CreateTextNode("5.00");

                // Добавление текстовых полей
                elem1.AppendChild(text1);
                elem2.AppendChild(text2);
                elem3.AppendChild(text3);
                elem4.AppendChild(text4);
                // Добавление новых элементо
                newPaper.AppendChild(elem1);
                newPaper.AppendChild(elem2);
                newPaper.AppendChild(elem3);
                newPaper.AppendChild(elem4);
                // Добавить новый узел в корневой элемент
                root.AppendChild(newPaper);
                // Сохранить изменения 
                doc.Save("newBooks.xml");

                // Сохранить документ
                doc.Save("newBooks.xml");
                
                Console.ReadKey();
            }
            catch (XmlException c)
            {
                // исключение генерируется когда XML не праильного формата
            }
        }
    }
}


