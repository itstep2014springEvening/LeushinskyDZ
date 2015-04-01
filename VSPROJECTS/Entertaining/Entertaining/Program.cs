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
            string filepath = @"C:\vans\git\LeushinskyDZ\VSPROJECTS\Entertaining\establishments.xml";
            FileStream fs = new FileStream(filepath, FileMode.Open);
            xmld.Load(fs);
            string DesiredTime = "";
            string NumberOfPeople = "";
            string MinimumAge = "";

            Console.WriteLine("Здравствуйте, юзер. Куда пойдём?");
            Console.WriteLine("Сформируйте запрос.");
            Console.WriteLine("Введите время: ");
            DesiredTime = Console.ReadLine();
            Console.WriteLine("Сколько вас:");
            NumberOfPeople = Console.ReadLine();
            if(DesiredTime=="1")
            {
                DesiredTime = "one";
            }
            if(DesiredTime=="2")
            {
                DesiredTime = "pare";
            }
            //проверка на company
            Console.WriteLine("Сколько лет вам:");
            MinimumAge = Console.ReadLine();


            // Console.WriteLine(xmld.GetElementsByTagName("bars")[0].FirstChild.InnerText); = печёный хряк
            // Console.WriteLine(xmld.GetElementsByTagName("bars")[0].FirstChild.Attributes.Item(1).Value); = 02:00




            // NumberOfPeople = (int)xmld.GetElementsByTagName("shebang")[1].Attributes.Item(4).Value;
            // NumberOfPeople = Convert.ToInt32(10);


            // Console.WriteLine(typeofent);
        }
    }
}
