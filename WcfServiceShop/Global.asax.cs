using Autofac;
using Autofac.Integration.Wcf;
using Domain;
using Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using WcfServiceShop.Configurations;

namespace WcfServiceShop
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            AutofacHostFactory.Container = AutofacConfig.GetContainer();
        }
    }
}