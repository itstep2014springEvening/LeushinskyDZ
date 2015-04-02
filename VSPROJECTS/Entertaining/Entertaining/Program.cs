using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Entertaining
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            
            DateTime ztime;
            int izcompany;
            string zcompany;
            int zage;
            string filepath = @"C:\vans\git\LeushinskyDZ\VSPROJECTS\Entertaining\establishments.xml";
            var organizations = XDocument.
                 Load(new StreamReader(File.OpenRead(filepath)))
                 .Root
                 .Elements()
                 .Select(element =>
                 {
                     try
                     {
                         return new Organization(element.Name.LocalName,
                        element.Attribute("name").Value,
                        element.Attribute("opentime").Value,
                        element.Attribute("closetime").Value,
                        element.Attribute("typeofpeople").Value,
                        element.Attribute("agelimit").Value
                        );
                     }
                     catch (Exception)
                     {

                         return null;
                     }

                 })
                 .Where(organization => organization != null)
                 .ToList();
            Console.WriteLine("Привет пользователь! Куда пойдём?");
            Console.WriteLine("Составь-ка запрос: ");
            Console.WriteLine("Желаемое время: (пример - 21:00)");
            try
            {
                ztime = DateTime.ParseExact(Console.ReadLine(), "HH:mm", null);
            }
            catch(FormatException)
            {
                Console.WriteLine("Неправильный ввод времени, попробуйте ещё раз.");
                ztime = DateTime.Now;
                return;
            }
            if(ztime>=new DateTime(2015, 4,2,00,00,00)&&ztime<=new DateTime(2015, 4,2,03,00,00))
            {
                ztime = ztime.AddDays(1);
            }
            
            Console.WriteLine("Сколько вас: (пример - 5)");
            try
            {
                izcompany = int.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Неправильный ввод количества людей, попробуйте ещё раз.");
                izcompany = 0;
                return;
            }
            Console.WriteLine("Ваш возраст: (пример - 21)");
            try
            {
                zage = int.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Неправильный ввод возраста, попробуйте ещё раз.");
                zage = 0;
                return;
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("\nМожем пойти в ...\n");
            organizations.ForEach(e =>
            {
                    switch (izcompany)
                    {
                        case 1: zcompany = "one"; break;
                        case 2: zcompany = "pair"; break;
                        default: zcompany = "company"; break;
                    }
                    if (e.OpenTime < ztime && ztime < e.CloseTime && zage >= e.AgeLimit && zcompany == e.TypeOfPeople)
                    {
                        Console.WriteLine(e.Type + " - " + e.Name);
                    }
                
            });
            return;

        }
    }

    public class Organization
    {
        public string Type { get; private set; }
        public string Name { get; private set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public string TypeOfPeople { get; set; }
        public int AgeLimit { get; set; }

        public Organization(string type, string name, string openTime, string closeTime, string typeOfPeople, string ageLimit)
        {
            if (string.IsNullOrEmpty(type))
            {
                throw new ArgumentNullException("type");
            }

            DateTime openTimeAsDateTime;
            if (DateTime.TryParse(openTime, out openTimeAsDateTime) == false)
            {
                throw new ArgumentException("openTime");
            }

            DateTime closeTimeAsDateTime;
            if (DateTime.TryParse(closeTime, out closeTimeAsDateTime) == false)
            {
                throw new ArgumentException("openTime");
            }
            int ageLimitAsStringAgeLimit;
            if (int.TryParse(ageLimit, out ageLimitAsStringAgeLimit) == false)
            {
                throw new ArgumentException("ageLimit");
            }


            Type = type;
            Name = name;
            OpenTime = openTimeAsDateTime;
            CloseTime = openTimeAsDateTime > closeTimeAsDateTime
                                    ? closeTimeAsDateTime.AddDays(1)
                                    : closeTimeAsDateTime;
            TypeOfPeople = typeOfPeople;
            AgeLimit = ageLimitAsStringAgeLimit;

        }

        public override string ToString()
        {
            return Type + Environment.NewLine
                + Name + Environment.NewLine
                + OpenTime + Environment.NewLine
                + CloseTime + Environment.NewLine
                + TypeOfPeople + Environment.NewLine
                + AgeLimit + Environment.NewLine
                ;
        }

    }
}
