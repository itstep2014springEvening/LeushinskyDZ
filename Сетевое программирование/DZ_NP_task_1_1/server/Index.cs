using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server
{
    class Index
    {
        [Key]
        public long IndexId { get; set; }
        public virtual List <Street> Streets { get; set; }
    }
}
