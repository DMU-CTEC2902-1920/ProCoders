using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using StoryWebsiteMVCProject.Controllers;
using StoryWebsiteMVCProject.Models;

namespace StoryWebsiteMVCProject.Tests.Controllers
{
    [TestClass]
    public class ShopControllerTest
    {
        [TestMethod]
        public void IndexWelcomeMessage()           
        {
            //Arrange

            ShopController controller = new ShopController();

            //Act
            ViewResult result = controller.Index();

            //Assert
            Assert.AreEqual("Welcome to the Shop. Kindly spend all your money!", controller.ViewBag.WelcomeMessage);

        }

        [TestMethod]
        public void ProductName()
        {
            //Arrange
            ProductModel model = new ProductModel();
            model.Name = "New Product";

            ShopController controller = new ShopController(model);

            //Act
            ViewResult viewResult = controller.Product();
            ProductModel result = viewResult.Model as ProductModel;

            //Assert
            Assert.AreEqual("New Product", result.Name);
        }

        [TestMethod]
        public void ProductIsBling()
        {
            //Arrange
            ProductModel model = new ProductModel();
           
            model.Name = "Test Product 2";
            model.Description = "Description of Test Product 2";
            model.Price = 222.99m;

            ShopController controller = new ShopController(model);

            //Act
            ViewResult result = controller.Product();

            //Assert
            Assert.AreEqual("Bling!" , result.ViewBag.SubTitle);

        }

        [TestMethod]
        public void ProductIsCheapAndNasty()
        {
            //Arrange

            ProductModel model = new ProductModel();
            model.Name = "Test Product1";
            model.Description = "Description of Test Product 1";
            model.Price = 2.99m;

            //Inject the controller's dependency on the model so we can test it
            ShopController controller = new ShopController(model);

            //Act
            ViewResult result = controller.Product();

            //Assert
            Assert.AreEqual("Cheap and nasty product!", result.ViewBag.SubTitle);

        }
    }
}
