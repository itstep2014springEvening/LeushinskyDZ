﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2exztest
{
   public class User
    {
        public long userId { get; set; }
        public string Name { get; set; }
        public DateTime? Date { get; set; }
        public virtual List<Device> Devices { get; set; }
    }
}
