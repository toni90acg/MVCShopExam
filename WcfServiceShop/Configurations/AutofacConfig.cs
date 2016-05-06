using Autofac;
using Domain;
using Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceShop.Configurations
{
    public class AutofacConfig
    {
        public static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();

            // Register your service implementations.
            builder.RegisterType<TicketService>().As<ITicketService>();
            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<RepositoryProduct>().As<IRepositoryProduct>();
            builder.RegisterType<RepositoryTicket>().As<IRepositoryTicket>();
            builder.RegisterType<UsersContext>().As<IDbBase>().As<IUnitOfWork>().InstancePerLifetimeScope();

            // Set the dependency resolver.
            return builder.Build();
        }
    }
}