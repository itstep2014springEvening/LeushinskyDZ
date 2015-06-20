using System;

using System.Xml;
using System.Xml.XPath;

namespace ExampleXPath2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Создание XPath документа.
            XPathDocument document = new XPathDocument("books.xml");

            // Единственное назначение XPathDocument - создание навигатора.
            XPathNavigator navigator = document.CreateNavigator();

            // При создании навигатора при помощи XPathDocument возможно выполнять только чтение.
            Console.WriteLine("Навигатор создан только для чтения. Свойство CanEdit = {0}.", navigator.CanEdit);

            // Используя XmlDocument навигатор можно использовать и для редактирования.
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load("books.xml");

            navigator = xmldoc.CreateNavigator();
            Console.WriteLine("Навигатор получил возможность редактирования. Свойство CanEdit = {0}.", navigator.CanEdit);

            // Теперь можно попробовать что-то записать в XML-документ.
            // Выполняем навигацию к узлу Book.
            navigator.MoveToChild("ListOfBooks", "");
            navigator.MoveToChild("Book", "");

            // Проводим вставку значений.
            navigator.InsertBefore("<InsertBefore>insert_before</InsertBefore>");
            navigator.InsertAfter("<InsertAfter>insert_after</InsertAfter>");
            navigator.AppendChild("<AppendChild>append_child</AppendChild>");

            navigator.MoveToNext("Book", "");

            navigator.InsertBefore("<InsertBefore>1111111111</InsertBefore>");
            navigator.InsertAfter("<InsertAfter>2222222222</InsertAfter>");
            navigator.AppendChild("<AppendChild>3333333333</AppendChild>");

            // Сохраняем изменения.
            xmldoc.Save("books.xml");

         
            Console.ReadKey();
        }
    }
}

/*
 * // Вычисление выражений с помощью XPath. (Пример: Вычисление суммы элементов)

namespace XML
{
    class Program
    {
        static void Main()
        {
            double sum = 0;

            // Создание XPath документа.
            XPathDocument document = new XPathDocument("books.xml");
            XPathNavigator navigator = document.CreateNavigator();

            // Вычисляющий запрос с предварительной компиляцией.
            XPathExpression expression = navigator.Compile("sum(ListOfBooks/Book/Price/text())");
            
            Console.WriteLine(expression.ReturnType);

            if (expression.ReturnType == XPathResultType.Number)
            {
                sum = (double)navigator.Evaluate(expression);
                Console.WriteLine(sum);
            }

            // Вычисляющий запрос без предварительной компиляции.
            // Кроме выборки производится арифметическое вычисление.
            sum = (double)navigator.Evaluate("sum(//Price/text())*10");
            Console.WriteLine(sum);

            // Delay.
            Console.ReadKey();
        }
    }
*/

/*

 // Вычисление min и max с помощью XPath.

namespace XML
{
    class Program
    {
        static void Main()
        {
            // Создание XPath документа.
            XPathDocument document = new XPathDocument("books.xml");
            XPathNavigator navigator = document.CreateNavigator();


            // Вычисление последнего элемента <book> в текущем узле контекста.
            XPathExpression expression = navigator.Compile("/ListOfBooks/Book[last()]");

            XPathNodeIterator iterator = navigator.Select(expression);

            iterator.MoveNext();
            Console.WriteLine(iterator.Current);

            // Delay.
            Console.ReadKey();
        }
    }
}
*/