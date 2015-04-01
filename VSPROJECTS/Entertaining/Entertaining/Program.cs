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
            string zcompany;
            int zage;
            string filepath = @"D:\git\LeushinskyDZ\VSPROJECTS\Entertaining\establishments.xml";
           var organizations =  XDocument.
                Load(new StreamReader(File.OpenRead(filepath)))
                .Root
                .Elements()
                .Select(element => element.Elements())
                .SelectMany(element => element)
                .Select(element => new Organization(element.Name.LocalName,
                    element.Value,
                    element.Attribute("opentime").Value,
                    element.Attribute("closetime").Value,
                    element.Attribute("typeofpeople").Value,
                    element.Attribute("agelimit").Value
                    ))
                .ToList();
             Console.WriteLine("Составьте запрос");
            Console.WriteLine("Желаемое время: ");
            ztime = DateTime.ParseExact(Console.ReadLine(), "HH:mm", null);
            //Console.WriteLine("Сколько вас: ");
          //  zcompany = Console.ReadLine();
          //  Console.WriteLine("Ваш возраст: ");
          //  zage = int.Parse(Console.ReadLine());
            
            organizations.ForEach(e =>
            {


                if (e.OpenTime > e.CloseTime)
                {
                    e.CloseTime = e.CloseTime.AddDays(1);
                    if (e.OpenTime < ztime && ztime < e.CloseTime /*&&zage>e.AgeLimit&&zcompany*/)
                    {
                        Console.WriteLine(e.Type + e.Name);
                    }
                }
                else
                {
                    if (e.OpenTime < ztime && ztime < e.CloseTime /*&&zage>e.AgeLimit&&zcompany*/)
                    {
                        Console.WriteLine(e.Type + e.Name);
                    }
                }

            });
            //organizations.ForEach(element=>{Console.WriteLine("{0}",element.OpenTime<ztime);});
           //organizations.ForEach(element =>
           //     {
           //         Console.WriteLine(element);
           //     });
           // Console.ReadKey();
            return ;
           
        }
    }

    public class Organization
    {
        public string Type { get; private set; }
        public string Name { get; private set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public string TypeOfPeople { get; set; }
        public string AgeLimit { get; set; }

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
            Type = type;
            Name = name;
            OpenTime = openTimeAsDateTime;
            CloseTime = closeTimeAsDateTime;
            TypeOfPeople = typeOfPeople;
            AgeLimit = ageLimit;
            
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
