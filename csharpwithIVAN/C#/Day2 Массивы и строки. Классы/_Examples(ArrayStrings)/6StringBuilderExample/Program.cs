using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "Язык программирования С#";
            str.Replace("#", "++");  // здесь создается еще одна строка
            Console.WriteLine(str);

            StringBuilder strB = new StringBuilder();
            strB.Append("Язык программирования С#");
            strB.Replace("#", "++");
            Console.WriteLine(strB);

            Console.ReadLine();
        }
    }
}
