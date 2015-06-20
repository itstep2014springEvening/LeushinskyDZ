using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Example4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            string text = "Салат - $15, Борщ - $3, Одеколон - $10, Салат - $8.";
            string pattern = @"(\w+) - \$(\d+)[.,]";
            Regex regEx = new Regex(pattern);
            Match match = regEx.Match(text);
            int total = 0;
            while (match.Success)
            {
                Console.WriteLine(match);
                total += int.Parse(match.Groups[2].ToString());
                match = match.NextMatch();
            }
            Console.WriteLine("Итого: $" + total);

            Console.ReadKey();
        }
    }
}
