using Autofac;
using Autofac.Integration.WebApi;
using AutoMapper;
using EZGB.DataAccess.Models;
using EZGB.Web.Business.Models;

namespace EZGB.Web.Business
{
    public class ApiModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly)
                .Where(t => t.Name.EndsWith("ModelBuilder") || t.Name.EndsWith("Service") || t.Name.EndsWith("Mapper"))
                .AsImplementedInterfaces();
        }   
    }
}