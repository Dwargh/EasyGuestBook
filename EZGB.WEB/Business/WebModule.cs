using Autofac;
using AutoMapper;
using EZGB.DataAccess.Models;
using EZGB.Web.Business.Models;

namespace EZGB.Web.Business
{
    public class WebModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly)
                .Where(t => t.Name.EndsWith("ModelBuilder") || t.Name.EndsWith("Service") || t.Name.EndsWith("Mapper"))
                .AsImplementedInterfaces();

            Mapper.Initialize(cfg => {
                cfg.CreateMap<PostModel, Post>();
                cfg.CreateMap<Post, PostModel>();
            });
        }
    }
}