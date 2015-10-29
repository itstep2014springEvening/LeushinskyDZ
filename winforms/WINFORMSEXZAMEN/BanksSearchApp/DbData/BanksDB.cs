using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbData
{
    public class BanksDB : DbContext
    {
        public BanksDB()
            : base("name=CompConString")
        {
            //?
        }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Bankomat> Bankomats { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
