using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Example6
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$";
            string[] emailAddresses = { 
            "david@pros.com", "d.j@server1.proseware.com", "jones@ms1.proseware.com", 
            "j.@server1.proseware.com",  "j@proseware.com9", "js#internal@proseware.com", 
            "j..s@proseware.com",  "js*@proseware.com", "js@proseware..com", 
            "js@proseware.com9",  "j.s@server1.proseware.com" };
            foreach (string emailAddress in emailAddresses)
            {
            if (Regex.IsMatch(emailAddress, pattern))
                Console.WriteLine("Email подтвержден");
            else
                Console.WriteLine("Некорректный email");
            }
            Console.ReadKey();
    }
  }
}
