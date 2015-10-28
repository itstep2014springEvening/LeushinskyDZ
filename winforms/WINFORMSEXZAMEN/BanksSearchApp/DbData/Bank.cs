﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbData
{
    public class Bank
    {
        [Key]
        public long BankId { get; set; }
        public string BankName { get; set; }
        public virtual List<Currency> Currencies { get; set; }
        public virtual List<Bankomat> Bankomats { get; set; }
        public virtual List<Service> Services { get; set; }
    }
}
