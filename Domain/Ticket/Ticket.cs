using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Ticket : EntityBase
    {
        public DateTime Date { get; set; }
        public ICollection<Detail> Details { get; set; }
    }
}
