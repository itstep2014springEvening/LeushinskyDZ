using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server
{
    class Street
    {
        [Key]
        public long StreetId { get; set; }
        public virtual Index Index { get; set; }
    }
}
