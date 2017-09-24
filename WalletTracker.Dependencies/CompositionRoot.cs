using System.Reflection;

using Autofac;

using WalletTracker.Infrastructure.Web;

namespace WalletTracker.Dependencies
{
    public static class CompositionRoot
    {
        public static IContainer RegisterDependencies(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.GetAssembly(typeof(WebClient))).AsImplementedInterfaces();

            return builder.Build();
        }
    }
}
