using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbData
{
    public class Currency
    {
        [Key]
        public long CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public double CurrencyBuyV { get; set; }
        public double CurrencySellV { get; set; }
        public virtual Bankomat Bankomat { get; set; }
        public long BankomatId { get; set; }
    }
}
