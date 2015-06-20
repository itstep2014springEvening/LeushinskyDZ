using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Example5Replace
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Мама     мыла     раму. ";
            string pattern = @"\s+";
            string target = " ";
            Regex regex = new Regex(pattern);
            string result = regex.Replace(s, target);
            Console.WriteLine(s);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
