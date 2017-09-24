using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;

using Autofac;
using Autofac.Integration.Mvc;

using WalletTracker.Dependencies;

namespace WebApplication1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            RegisterDependencies();
        }

        private void RegisterDependencies()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            var container = CompositionRoot.RegisterDependencies(builder);

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
