using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Example2Matches
{
    class Program
    {
        static void Main(string[] args)
        {
// поиск нескольких совпадений в строке
Console.WriteLine("Пример 1");
string pattern = "abc";
string input = "abc123abc456abc789";
foreach (Match match in Regex.Matches(input, pattern))
{ Console.WriteLine("{0} найдено! Индекс -  {1}.",
                                match.Value, match.Index);
}
           
Console.WriteLine("Использование   Match");
Match match2 = Regex.Match(input, pattern);
while (match2.Success)
{
    Console.WriteLine("{0} найдено! Индекс -   {1}.",
                                    match2.Value, match2.Index);
    match2 = match2.NextMatch();
}

Console.WriteLine("Пример 2");
string pattern2 = @"\b91*9*\b";
string input2 = "99 95 919 929 9119 9219 999 9919 91119";
foreach (Match match in Regex.Matches(input2, pattern2))
    Console.WriteLine("{0} найдено! Индекс - {1}.",
                                match.Value, match.Index);
            
            Console.ReadKey();
        }
    }
}
