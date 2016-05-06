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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ITicketService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ITicketService
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/Ticket")]
        IEnumerable<Ticket> GetAll(DateTime from, DateTime to);

        [OperationContract]
        [WebGet(UriTemplate = "/Ticket/{id}", ResponseFormat = WebMessageFormat.Json)]
        Ticket Get(string id);

        [OperationContract]
        [WebInvoke(UriTemplate = "/AddTicket",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json)]
        Ticket Add(Ticket ticket);
    }
}
