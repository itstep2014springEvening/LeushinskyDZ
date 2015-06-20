using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Example5
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://www.contoso.com:8080/letters/readme.html";
            Regex r = new Regex(@"^(?<proto>\w+)://[^/]+?(?<port>:\d+)?/");
            Match m = r.Match(url);
            if (m.Success)
                Console.WriteLine(r.Match(url).Result("${proto}${port}"));

            Console.ReadKey();
        }
    }
}
