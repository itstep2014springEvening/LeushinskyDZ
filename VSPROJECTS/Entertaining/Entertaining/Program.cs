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
        public class Establishments
        {
            public string TypeOfestablishment;
            public string nameOfEstablishmentl;
            public DateTime openTime;
            public DateTime closeTime;
            public string typeOfCompany;
            public int ageLimit;
        }
        private static void Main(string[] args)
        {
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

           organizations.ForEach(element =>
                {
                    Console.WriteLine(element);
                });
            Console.ReadKey();
            return ;
            //clubNumber1.openTime = DateTime.ParseExact((xmld.GetElementsByTagName("bars")[0]
            //    .ChildNodes[0].Attributes.Item(0).Value), "HH:mm", null);

            //clubNumber1.closeTime = DateTime.ParseExact((xmld.GetElementsByTagName("bars")[0]
            //    .ChildNodes[0].Attributes.Item(1).Value), "HH:mm", null);

            //clubNumber1.typeOfCompany = xmld.GetElementsByTagName("bars")[0]
            //    .ChildNodes[0].Attributes.Item(2).Value;

            //clubNumber1.ageLimit = int.Parse((xmld.GetElementsByTagName("bars")[0]
            //    .ChildNodes[0].Attributes.Item(3).Value));
            //Console.WriteLine(clubNumber1.openTime);



            //string DesiredTime = "";
            //string NumberOfPeople = "";
            //string MinimumAge = "";
            //string[] openTime = new string[100];
            //string[] closeTime = new string[100];
            //string[] typeofpeople = new string[100];
            //string[] agelimit = new string[100];
            //string teststring = xmld.GetElementsByTagName("bars")[0].FirstChild.Attributes.Item(1).Value;
            //Console.Write(teststring);
            //for (int i = 0; i < 4; i++)
            //{
            //    openTime[i] = xmld.GetElementsByTagName("bars")[0].FirstChild.Attributes.Item(i).Value;
            //    Console.WriteLine(openTime[i]);
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    openTime[i] = xmld.GetElementsByTagName("bars")[1].ChildNodes[i].Attributes.Item(i).Value;
            //    Console.WriteLine(openTime[i]);
            //}
            //IEnumerable<Bar> bars;

            //XDocument xmlDoc = XDocument.Load(new StreamReader(File.OpenRead(@"pathtofile")));

            //xmlDoc
            //    .Nodes()
            //    .Select(n => new Bar()
            //    {
            //        Open = n.
            //    })

            //DateTime parsedOpendDate;
            //bars.Where(b => b.Open >= parsedOpendDate && )
            //    .ToList()
            //    .ForEach(b => Console.WriteLine(b));

            //foreach (var bar in bars.Where(b => b.Open >= parsedOpendDate && ).)
            //{
            //    Console.WriteLine(bar);
            //}
            /* Console.WriteLine("Здравствуйте, юзер. Куда пойдём?");
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
            MinimumAge = Console.ReadLine();*/


            // Console.WriteLine(xmld.GetElementsByTagName("bars")[0].FirstChild.InnerText); = печёный хряк
            // Console.WriteLine(xmld.GetElementsByTagName("bars")[0].FirstChild.Attributes.Item(1).Value); = 02:00

            // string teststring = xmld.GetElementsByTagName("bars")[0].FirstChild.Attributes.Item(0).Value;
            // string teststring2 = xmld.GetElementsByTagName("bars")[0].FirstChild.Attributes.Item(1).Value;
            //DateTime xxx = DateTime.ParseExact(teststring, "HH:mm", CultureInfo.InvariantCulture);
            //DateTime xxx2 = DateTime.ParseExact(teststring2, "HH:mm", CultureInfo.InvariantCulture);
            // if (xxx > xxx2)
            // {
            //     Console.WriteLine("Y");
            // }
            // else
            // {
            //     Console.WriteLine("N");
            // }
            // Console.WriteLine(teststring);


            // NumberOfPeople = (int)xmld.GetElementsByTagName("shebang")[1].Attributes.Item(4).Value;
            // NumberOfPeople = Convert.ToInt32(10);


            // Console.WriteLine(typeofent);
        }
    }

    public class Organization
    {
        public string Type { get; private set; }
        public string Name { get; private set; }
        public DateTime OpenTime { get; set; }
        public string CloseTime { get; set; }
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

            Type = type;
            Name = name;
            OpenTime = openTimeAsDateTime;
            CloseTime = closeTime;
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

//    class Bar
//    {
//        public DateTime Open { get; set; }

//        public void SetOpen(string stringDate)
//        {

//        }
//    }
//}
