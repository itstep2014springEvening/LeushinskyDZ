using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbData
{
    public class Service
    {
        [Key]
        public long ServiceId { get; set; }
        public string ServiceName { get; set; }
        //public virtual List<BankomatToService> BankomatToServices { get; set; }
        
    }
}
