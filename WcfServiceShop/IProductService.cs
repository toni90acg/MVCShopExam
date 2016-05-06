using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceShop
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IProductService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "Product")]
        IEnumerable<Product> GetAll();

        [OperationContract]
        [WebGet(UriTemplate = "Product/{id}", ResponseFormat = WebMessageFormat.Json)]
        Product Get(string id);
    }
}
