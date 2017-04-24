using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HealthCatalystApp.Controllers;

namespace HealthCatalystApp.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        /// <summary>
        /// Unit test to verify the index page returns
        /// a view when called
        /// </summary>
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Unit test to verify that the json call returns
        /// some value for the given parameter "ma"
        /// </summary>
        [TestMethod]
        public void SearchResult()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Atc
            JsonResult result = controller.SearchResults("ma") as JsonResult;

            // Assert
            Assert.IsNotNull(result.Data);


        }

    }

}
