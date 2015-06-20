using System;

using System.Text.RegularExpressions; // пространство имен для 
                                      // регулярных выражений

namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Основы решулярных выражений!");
                Console.WriteLine("   Пример 1");
                Console.WriteLine(Regex.Match("строчка",@"строч?ка"));
                Console.WriteLine(Regex.Match("строка", @"строч?ка"));
                Console.WriteLine(Regex.Match("строчька", @"строч?ка"));
            
            Console.WriteLine("   Пример 2");
                Regex reg2 = new Regex(@"строч?ка");
                Console.WriteLine(reg2.Match("строчка"));
                Console.WriteLine(reg2.Match("строка"));
                Console.WriteLine(reg2.Match("строчька"));
             
            Console.WriteLine("   Пример 3");
                Regex reg3 = new Regex(@"строч?ка");    
                Console.WriteLine(reg3.Match("Заглавная строка пишется").Success);
                Console.WriteLine(reg3.Match("Заглавная строка пишется").Length);
                Console.WriteLine(reg3.Match("Заглавная строка пишется").Index);
                Console.WriteLine(reg3.Match("Заглавная строка пишется").Value);
            
            Console.WriteLine("   Пример 4");
                Console.WriteLine(Regex.Match("Иванов", "Иван(ов|овна)?"));
                Console.WriteLine(Regex.Match("Иван", "Иван(ов|овна)?"));
                Console.WriteLine(Regex.Match("Иваныч", "Иван(ов|овна)?"));
            
            Console.WriteLine("   Пример 5");
                Console.WriteLine(Regex.Match("иван", "Иван(ов|овна)?").Success);    
                Console.WriteLine(Regex.Match("иван", "Иван(ов|овна)?",RegexOptions.IgnoreCase).Success);
                
            Console.WriteLine("   Пример 6 Наборы символов!");
            Console.WriteLine(Regex.Matches("Заглавная строка пишется", "[а]").Count);
            Console.WriteLine(Regex.Matches("Заглавная строка пишется", "[За]").Count);
            Console.WriteLine(Regex.Match("строчка строка", "с[^йёъьц]").Success);
            Console.Write (Regex.Match ("b1-c4", @"[a-h]\d-[a-h]\d").Success); 


            Console.Read();
        }
    }
}
