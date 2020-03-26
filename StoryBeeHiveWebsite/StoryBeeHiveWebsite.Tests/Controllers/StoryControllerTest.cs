using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using StoryBeeHiveWebsite.Models;
using StoryBeeHiveWebsite.Controllers;
using System.Collections.Generic;

namespace StoryBeeHiveWebsite.Tests.Controllers
{
    [TestClass]
    public class StoryControllerTest
    {
        [TestMethod]
        public void StoryWriting_Message()
        {
            //Arrange
            StoryController controller = new StoryController();

            //Act
            ViewResult result = controller.StoryWriting() as ViewResult;

            //Assert
            Assert.AreEqual("Story Writing Tips", result.ViewBag.Message);
        }

        [TestMethod]
        public void StoryWriting_WelcomeMessage()
        {
            //Arrange
            StoryController controller = new StoryController();

            //Act
            ViewResult result = controller.StoryWriting() as ViewResult;

            //Assert
            Assert.AreEqual("Welcome to StoryBeeHive. A place to find good stories", result.ViewBag.WelcomeMessage);
        }

        [TestMethod]
        public void StoryWriting_Comment_NewStory()
        {
            //Arrange
            Story model = new Story();
            model.StoryId = 5;
            model.Title = "Test Story 1";
            model.Description = "Life is going good but still I feel empty at times when I am alone";
            model.Comments = new List<Comment>
                {
                    new Comment {CommentId=1, Description="good story", StoryId=5}
                };
            model.CategoryId = 1;
            model.AuthorId = 2;

            //Inject the controller's dependency on the model so we can test it
            StoryController controller = new StoryController(model);

            //Act
            ViewResult result = controller.StoryWriting() as ViewResult;

            //Assert
            Assert.AreEqual("New Story", result.ViewBag.SubTitle);
        }

        [TestMethod]
        public void StoryWriting_Comment_PopularStory()
        {
            //Arrange
            Story model = new Story();
            model.StoryId = 5;
            model.Title = "Test Story 1";
            model.Description = "Life is going good but still I feel empty at times when I am alone";
            model.Comments = new List<Comment>
                {
                    new Comment {CommentId=1, Description="Good story", StoryId=5},
                    new Comment {CommentId=2, Description="Well written story", StoryId=5},
                    new Comment {CommentId=3, Description="A story worth reading", StoryId=5},
                    new Comment {CommentId=4, Description="Meaningful story", StoryId=5}
                };
            model.CategoryId = 1;
            model.AuthorId = 2;

            //Inject the controller's dependency on the model so we can test it
            StoryController controller = new StoryController(model);

            //Act
            ViewResult result = controller.StoryWriting() as ViewResult;

            //Assert
            Assert.AreEqual("Popular Story", result.ViewBag.SubTitle);
        }

        [TestMethod]
        public void StoryWriting_Description_LongDescription()
        {
            //Arrange
            Story model = new Story();
            model.StoryId = 5;
            model.Title = "Test Story 1";
            model.Description = "Life is going good but still I feel empty at times when I am alone";
            model.Comments = new List<Comment>
                {
                    new Comment {CommentId=1, Description="Good story", StoryId=5},
                    new Comment {CommentId=2, Description="Well written story", StoryId=5},
                    new Comment {CommentId=3, Description="A story worth reading", StoryId=5}

                };
            model.CategoryId = 1;
            model.AuthorId = 2;

            //Inject the controller's dependency on the model so we can test it
            StoryController controller = new StoryController(model);

            //Act
            ViewResult result = controller.StoryWriting() as ViewResult;

            //Assert
            Assert.AreEqual("Long Description", result.ViewBag.DescriptionLength);
        }

        [TestMethod]
        public void StoryWriting_Description_ShortDescription()
        {
            //Arrange
            Story model = new Story();
            model.StoryId = 5;
            model.Title = "Test Story 1";
            model.Description = "Life is going good";
            model.Comments = new List<Comment>
                {
                    new Comment {CommentId=1, Description="Good story", StoryId=5},
                    new Comment {CommentId=2, Description="Well written story", StoryId=5}

                };
            model.CategoryId = 1;
            model.AuthorId = 2;

            //Inject the controller's dependency on the model so we can test it
            StoryController controller = new StoryController(model);

            //Act
            ViewResult result = controller.StoryWriting() as ViewResult;

            //Assert
            Assert.AreNotEqual("Short Description", result.ViewBag.DescriptionLength);
        }

        
    }
}
