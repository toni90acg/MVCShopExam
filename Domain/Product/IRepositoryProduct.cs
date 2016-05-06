using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IRepositoryProduct
    {
        IEnumerable<Product> Products { get; set; }

        Product Get(int id);
        IEnumerable<Product> GetAll();
    }
}
