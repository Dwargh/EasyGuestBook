using Autofac;

namespace EZGB.DataAccess
{
    public class DataAccessModule : Module
    {
       protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces();

           builder.RegisterType<ConnectionProvider>().As<IConnectionProvider>();
        }
    }
}
