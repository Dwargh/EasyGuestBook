using System;
using Autofac;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EZGB.Web.Business;

namespace EZGB.Web.Tests
{
    [TestClass]
    public abstract class TestBase
    {
        protected IContainer Container { get; private set; }

        protected TestBase()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new WebModule());
            Container = builder.Build();
        }
    }
}
