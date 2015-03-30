using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Runtime.CompilerServices;

namespace Entertaining
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmld = new XmlDocument();
            string DesiredTimeBegin = "";
            string DesiredTimeEnd = "";
            int NumberOfPeople = 0;
            int MinimumAge = 0;
           
            string filepath = @"C:\vans\git\LeushinskyDZ\VSPROJECTS\Entertaining\establishments.xml";
            
            FileStream fs = new FileStream(filepath, FileMode.Open);
            xmld.Load(fs);
            string typeofent = xmld.GetElementsByTagName("shebang")[1].FirstChild.Value;
            string typeofent2 = xmld.GetElementsByTagName("shebang")[1].Attributes.Item(4).Value;


            Console.WriteLine(typeofent2);
        }
    }
}
