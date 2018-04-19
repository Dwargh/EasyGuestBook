using Autofac;
using Autofac.Integration.Mvc;
using EZGB.DataAccess;
using EZGB.Web.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace EZGB.Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            var builder = new ContainerBuilder();
            var thisAssembly = typeof(MvcApplication).Assembly;
            builder.RegisterControllers(thisAssembly);
            builder.RegisterModelBinders(thisAssembly);
            builder.RegisterFilterProvider();
            RegisterModules(builder);

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }

        private void RegisterModules(ContainerBuilder builder)
        {
            builder.RegisterModule(new DataAccessModule());
            builder.RegisterModule(new WebModule());
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception exception = Server.GetLastError();
            Server.ClearError();
            Response.Redirect("/Home/Error");
        }
    }
}
