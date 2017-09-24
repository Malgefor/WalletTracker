using System;
using System.Web.Routing;

using Autofac;
using Autofac.Integration.Mvc;

namespace WalletTracker.Config
{
    public class Global : System.Web.HttpApplication
    {
        private IContainer container;

        protected void Application_Start(object sender, EventArgs e)
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            RegisterDependencies();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }

        private void RegisterDependencies()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers();
            this.container = Dependencies.CompositionRoot.RegisterDependencies(builder);
        }
    }
}