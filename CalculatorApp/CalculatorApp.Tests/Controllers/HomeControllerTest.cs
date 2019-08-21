using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApp;
using CalculatorApp.Controllers;
using CalculatorApp.Models;

namespace CalculatorApp.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        HomeController homeController;
        CalculatorModels calculatorModels;
        [TestInitialize]
        public void CreateController()
        {
            homeController = new HomeController();
            calculatorModels = new CalculatorModels();
        }
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
        [TestMethod]
        public void TestMethod1()
        {
            //Act
            var result = homeController.Index();

            //Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Act
            var result = homeController.Index() as ViewResult;

            //Assert
            Assert.AreEqual(string.Empty, result.ViewName);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            string command = "add";

            //Act
            ViewResult result = homeController.Index(calculatorModels, command) as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            string command = "sub";


            //Act
            ViewResult result = homeController.Index(calculatorModels, command) as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            string command = "mul";

            //Act
            ViewResult result = homeController.Index(calculatorModels, command) as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            string command = "div";

            //Act
            ViewResult result = homeController.Index(calculatorModels, command) as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            CalculatorModels model = null;

            //Act
            ViewResult result = homeController.Index() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
