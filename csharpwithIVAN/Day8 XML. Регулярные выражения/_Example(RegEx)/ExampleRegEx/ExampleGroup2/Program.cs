using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExampleGroup2
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Создадим регулярное выражения для поиска 
             * простых адресов e-mail: (\w+)@(\w+).(\w+)*/
            Regex regEx = new Regex(@"(\w+)@(\w+).(\w+)");          
            Match m = regEx.Match("Мой почтовый адрес bird@yandex.ru");

            Console.WriteLine(m.Groups[0]); // выведет на экран bird@yandex.ru"
            Console.WriteLine(m.Groups[1]); // выведет на экран bird
            Console.WriteLine(m.Groups[2]); // выведет на экран yandex
            Console.WriteLine(m.Groups[3]); // выведет на экран ru
            Console.ReadKey();
        }
    }
}
