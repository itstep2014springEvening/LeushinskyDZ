using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace server
{
    class StreetDB: DbContext
    {
        public StreetDB():base("name=CompConString")
        {
            //?
        }
        public DbSet<Index> Indexes { get; set; }
        public DbSet<Street> Streets { get; set; }
    }
}
