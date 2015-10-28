using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbData
{
    public class Bankomat
    {
        [Key]
        public long BankomatId { get; set; }
        public string BankomatName { get; set; }
        public string BankOwnerName { get; set; }
        public string Telephone { get; set; }
        public string CityName { get; set; }
        public string StreetName { get; set; }
        public string HomeNumber { get; set; }
        public double CoordinateX { get; set; }
        public double CoordinateY { get; set; }
        public DateTime? OpenDate { get; set; }
        public string WorkingTime { get; set; }
        public string PersonalInformation { get; set; }
        public string Review { get; set; }
        public string AdditionalInformation { get; set; }
        public virtual Bank Bank { get; set; }
    }
}
