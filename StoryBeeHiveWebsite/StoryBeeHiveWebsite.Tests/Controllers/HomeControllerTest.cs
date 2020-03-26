using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoryBeeHiveWebsite;
using StoryBeeHiveWebsite.Controllers;

namespace StoryBeeHiveWebsite.Tests.Controllers
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
        }

        [TestMethod]
        public void About_WelcomeMessage()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Welcome to About us page", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void About_ViewBagMotto()
        {
            // Arrange
            HomeController homeController = new HomeController();
            // Act
            ViewResult result = homeController.About();
            // Assert
            Assert.AreEqual("Become a better writer with StoryBeeHive’s creative writing platform.", result.ViewBag.Motto);
        }
        [TestMethod]
        public void About_ViewBagDescription()
        {
            // Arrange
            HomeController homeController = new HomeController();
            // Act
            ViewResult result = homeController.About();
            // Assert
            Assert.AreEqual("StoryBeeHive lets anyone make visual stories in seconds. We curate artwork from illustrators around the world and inspire writers of any age to turn those imagesinto original stories.It's a simple idea that has attracted millions of writers, readers, and artists to our platform. Families and friends, teachers and students, and amateurs and professionals have created more than 30 million stories—making StoryBeeHive one of the world's largest storytelling communities.", result.ViewBag.Description);
        }
        [TestMethod]
        public void About_ViewBagTips()
        {
            // Arrange
            HomeController homeController = new HomeController();
            // Act
            ViewResult result = homeController.About();
            // Assert
            Assert.AreEqual("You may have learned the basics of story structure in beginning composition class, but here’s a refresher. The story must have a beginning, middle, and end. The character follows a path called the story arc. It begins with an event that sets the wheels in motion. That’s followed by rising action, which means that every step in the story’s progression raises the stakes just a bit, increasing the conflict and tension. Then, the story reaches a climactic turning point. For better or worse, from here forward your character will be changed as a result of his journey through the events. The final piece is the end, or denouement, which wraps the story up in a satisfying way and solidifies both its outcome and its theme.", result.ViewBag.Tips);
        }
    }
}
