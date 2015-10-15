using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace banksearchapp_Ivan
{
    public class BanksDB:DbContext
    {
        public BanksDB():base("name=CompConString")
        {
            //?
        }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Bankomat> Bankomats { get; set; }
    }
}
