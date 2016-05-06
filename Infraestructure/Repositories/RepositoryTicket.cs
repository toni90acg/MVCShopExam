using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure
{
    public class RepositoryTicket : RepositoryBase<Ticket>, IRepositoryTicket
    {
        public RepositoryTicket(IDbBase context) 
            :base(context){}

        public IEnumerable<Ticket> Tickets { get; set; }

        public Ticket Get(int id)
        {
            return GetSet.Where(c => c.Id == id).FirstOrDefault();
        }

        public IEnumerable<Ticket> GetAll(DateTime from, DateTime to)
        {
            return GetSet.Where(c => c.Date >= from && c.Date <= to);
        }

        public Ticket Add(Ticket ticket)
        {
            if (null == ticket)
            {
                throw new ArgumentNullException();
            }
            return GetSet.Add(ticket);
        }

    }
}
