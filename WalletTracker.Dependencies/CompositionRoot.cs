using System.Reflection;

using Autofac;

using WalletTracker.Domain.Wallet;
using WalletTracker.Infrastructure.Web;

namespace WalletTracker.Dependencies
{
    public static class CompositionRoot
    {
        public static IContainer RegisterDependencies(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.GetAssembly(typeof(WebClient))).AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(Assembly.GetAssembly(typeof(WalletInfoService))).AsImplementedInterfaces();

            return builder.Build();
        }
    }
}
