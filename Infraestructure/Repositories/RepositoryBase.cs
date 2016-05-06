using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure
{
    public class RepositoryBase<T> where T:EntityBase
    {
        readonly IDbBase _context;
        public RepositoryBase(IDbBase context)
        {
            _context = context;
        }

        protected DbSet<T> GetSet
        {
            get
            {
                return _context.Set<T>();
            }
        }
    }
}
