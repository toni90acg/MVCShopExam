using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure
{
    public class RepositoryProduct : RepositoryBase<Product>, IRepositoryProduct
    {
        public RepositoryProduct(IDbBase context) 
            :base(context){}

        public IEnumerable<Product> Products { get; set; }
            
        public IEnumerable<Product> GetAll()
        {
            return GetSet.Select(c => c);
        }

        public Product Get(int id)
        {
            return GetSet.Where(c => c.Id == id).FirstOrDefault();
        }
    }
}
