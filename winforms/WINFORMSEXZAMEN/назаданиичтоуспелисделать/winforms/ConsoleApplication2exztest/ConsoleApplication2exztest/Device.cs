using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2exztest
{
    public class Device
    {
        public long DeviceId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public double Price { get; set; }
        public virtual User User { get; set; }
    }
}
