using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Z.E.R.O_1.web;
using Z.E.R.O_1.web.Controllers;

namespace Z.E.R.O_1.web.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
