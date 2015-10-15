using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbManipulating
{
    public class Bankomat
    {
        [Key]
        public long BankomatId { get; set; }
        public string BankomatName { get; set; }
        public string BankOwnerName { get; set; }
        public double Telephone { get; set; }
        public string Address { get; set; }
        public double CoordinateX { get; set; }
        public double CoordinateY { get; set; }
        public DateTime OpenDate { get; set; }
        public string WorkingTime { get; set; }
        //public Dictionary<string, double> CurrencyValue { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyValueB { get; set; }
        public string CurrencyValueS { get; set; }
        public string PersonalInformation { get; set; }
        public string Review { get; set; }
        public string Services { get; set; }
        public string AdditionalInformation { get; set; }
        public virtual Bank Bank { get; set; }
    }
}
