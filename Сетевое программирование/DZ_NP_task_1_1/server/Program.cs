using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace server
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] DBSearch = Directory.GetFiles(Environment.CurrentDirectory, "*.mdf");
            if (DBSearch.Length==0)
            {
                StreetDB std = new StreetDB();

                //Index s1 = new Indexes()
                //{
                //    Street = "Ул. Голубя"
                //};

                //Index s2 = new Indexes()
                //{
                //    Street = "Ул. Петровича"
                //};

                //Index s3 = new Indexes()
                //{
                //    Street = "Ул. Хохотинская"
                //};

                //std.Streets.Add(s1);
                //std.Streets.Add(s2);
                //std.Streets.Add(s3);
                std.SaveChanges();
            }
        }
    }
}
