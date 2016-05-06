using Domain;
using Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceShop
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ProductService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ProductService.svc o ProductService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ProductService : IProductService
    {
        readonly IRepositoryProduct _repository;

        public ProductService(IRepositoryProduct repository)
        {
            if (null == repository)
            {
                throw new ArgumentNullException();
            }
            _repository = repository;
        }

        public IEnumerable<Product> GetAll()
        {
            return _repository.GetAll();
        }

        public Product Get(string id)
        {
            int idProduct = Helper.TryParseToInt(id);
            return _repository.Get(idProduct);
        }
    }
}
