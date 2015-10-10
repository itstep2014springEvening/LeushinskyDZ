using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2exztest
{
    public class ComputersDB:DbContext
    {
        public ComputersDB():base("name=CompConString")
        {
            //?
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Device> Devices { get; set; }
    }
}
