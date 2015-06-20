using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ExampleXmlDocument
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {   XmlDocument doc = new XmlDocument();
                // разбирает XML  и  строит его представление в памяти
                doc.Load("books.xml");
                // DocumentElement- корневой элемент XML
                OutputNode(doc.DocumentElement);
            }
            catch (XmlException)
            {
             // исключение генерируется- когда XML не праильного формата
            }

            Console.ReadKey();
        }

        // рекурсия ...
        static void OutputNode(XmlNode node)
        {   // вывод элементов
            Console.WriteLine("Type={0}\tName={1}\tValue={2}", node.NodeType,node.Name, node.Value);
           
            // есть ли у узла атрибуты?
            if (node.Attributes != null)
            { // перебор арибутов узла!
                foreach (XmlAttribute attr in node.Attributes)
                {   // вывод типа, имени и значения атрибута
                    Console.WriteLine("Type= {0}\tName={1}\tValue={2}", attr.NodeType, attr.Name, attr.Value);
                }
            }  
            
            // есть ли у узла  потомки?
            if (node.HasChildNodes)
            {   // получение набора узлов - потомков
                XmlNodeList children = node.ChildNodes;
                // перебор потовков-узлов
                foreach (XmlNode child in children)
                 { OutputNode(child); }
            }

        } 
    }
}
