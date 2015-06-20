using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Example3Split
{
    class Program
    {
        static void Main(string[] args)
        {
// Помещает элементы нумерованного списка в массив строк
string input = "1. С# 2. WinForms 3.ADO.NET 4. WPF 5. ASP.NET";
string pattern = @"\d{1,2}\.\s?"; // ? - для 3.ADO.NET
foreach (string item in Regex.Split(input, pattern))
{
    if (!String.IsNullOrEmpty(item))
        Console.WriteLine(item);
}

Console.WriteLine("   Пример 2");
// Разбиение текста на слова!
string text = "Салат -  $4, Борщ -$3, Одеколон - $10.";
string pattern2 = "[- ,.]+";
Regex r = new Regex(pattern2);
string[] words = r.Split(text);
foreach (string word in words)
{
    Console.WriteLine(word);
}

            Console.ReadKey();
        }
    }
}
