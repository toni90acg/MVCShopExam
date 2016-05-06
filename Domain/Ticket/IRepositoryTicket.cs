using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IRepositoryTicket
    {
        IEnumerable<Ticket> Tickets { get; set; }

        Ticket Get(int id);
        IEnumerable<Ticket> GetAll(DateTime from, DateTime to);
        Ticket Add(Ticket ticket);
    }
}
