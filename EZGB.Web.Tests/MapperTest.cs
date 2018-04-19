using System;
using Autofac;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EZGB.Web.Business.Models;
using EZGB.Web.Business.Mappers;

namespace EZGB.Web.Tests
{
    [TestClass]
    public class MapperTest : TestBase
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var mapper = Container.Resolve<IPostMapper>();
            var model = new PostModel() {
                Date = DateTime.Now,
                Email = "test@test.test",
                Heading = "Test!",
                Message = "Testing test."
            };
            // Act
            var post = mapper.Map(model);
            // Assert
            Assert.AreNotEqual(model.GetType(), post.GetType());
            Assert.AreEqual(model.Message, post.Message);
            Assert.AreEqual(model.Date, post.Date);
        }
    }
}
