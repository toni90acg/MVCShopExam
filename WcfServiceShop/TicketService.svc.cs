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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "TicketService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione TicketService.svc o TicketService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class TicketService : ITicketService
    {
        readonly IRepositoryTicket _repository;
        readonly IUnitOfWork _unitOfWork;

        public TicketService(IRepositoryTicket repository, IUnitOfWork unitOfWork)
        {
            if (null == repository)
            {
                throw new ArgumentNullException();
            }
            _repository = repository;

            if (null == unitOfWork)
            {
                throw new ArgumentNullException();
            }
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Ticket> GetAll(DateTime from, DateTime to)
        {
            return _repository.GetAll(from, to);
        }

        public Ticket Get(string id)
        {
            int idTicket = Helper.TryParseToInt(id);
            return _repository.Get(idTicket);
        }
        
        public Ticket Add(Ticket ticket)
        {
            Ticket t = _repository.Add(ticket);
            _unitOfWork.SaveChanges();
            return t;
        }
    }
}
