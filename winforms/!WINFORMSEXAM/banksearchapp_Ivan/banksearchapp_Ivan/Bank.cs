﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banksearchapp_Ivan
{
    public class Bank
    {
        [Key]
        public long BankId { get; set; }
        public string Name { get; set; }
        public DateTime? Date { get; set; }
        public virtual List<Bankomat> Bankomats { get; set; }
    }
}
