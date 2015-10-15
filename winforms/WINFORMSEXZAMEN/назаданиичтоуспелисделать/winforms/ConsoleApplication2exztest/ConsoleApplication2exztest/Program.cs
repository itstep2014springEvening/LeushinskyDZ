using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2exztest
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputersDB db = new ComputersDB();
            Device dev1 = new Device()
            {
                Name = "Lolo",
                Price = 333,
                Country="ahahaha"
            };

            Device dev2 = new Device()
            {
                Name = "Koko",
                Price = 333,
                Country="vivivi"
            };

            User user = new User()
            {
                Name="Van",
                Date = DateTime.Now,
                Devices = new List<Device>()
            };
            user.Devices.Add(dev1);

            db.Users.Add(user);
            db.SaveChanges();

            foreach(var it in db.Devices)
            {
                Console.WriteLine(it.Country);
            }

            Console.Read();
        }
    }
}
