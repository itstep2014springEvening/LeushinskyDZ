using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbData
{
    public class BankomatToService
    {
        [Key]
        public long BankomatToServiceId { get; set; }

        public long BankomatId { get; set; }
        public long ServiceId { get; set; }

        public virtual Bankomat Bankomat { get; set; }
        public virtual Service Service { get; set; }
    }
}
