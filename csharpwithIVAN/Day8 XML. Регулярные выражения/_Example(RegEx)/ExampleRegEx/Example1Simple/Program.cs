using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Example1Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            // поиск номера соц страхования (его форма XXX-XX-XXXX)
            string[] values = { "123-22-3789", "123-2-3333" };
            string pattern = @"^\d{3}-\d{2}-\d{4}";
            foreach (string value in values)
            {
                if (Regex.IsMatch(value, pattern))
                    Console.WriteLine("{0} номер соц страхования!", value);
                else
                    Console.WriteLine("{0}: номер не опознан!", value);
            }

            Regex regEx = new Regex(pattern, RegexOptions.IgnoreCase);
            foreach (string value in values)
            {
                if (regEx.IsMatch(value))
                    Console.WriteLine("{0} номер соц страхования!", value);
                else
                    Console.WriteLine("{0}: номер не опознан!", value);
            }

            
            Console.ReadKey();
        }
    }
}
