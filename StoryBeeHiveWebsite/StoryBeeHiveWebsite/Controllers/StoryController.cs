using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using StoryBeeHiveWebsite.Models;

namespace StoryBeeHiveWebsite.Controllers
{
    public class StoryController : Controller
    {
        private Story _model;
        public StoryController() { }
        public StoryController(Story model)
        {
            _model = model;
        }


        StoryContext db = new StoryContext();
        // GET: Story
        public ActionResult Index()
        {
            ViewBag.Popular = "Most Popular";
            var stories = db.Stories.Include(s => s.Author).Include(s => s.Category);
            
            return View(stories.ToList( ));
        }

        public ActionResult Details(int? id)
        {
            ViewBag.Message = "Click on 'Show Comments' and Scroll Down to see the Comments on the story";


            if (id == null) return new HttpNotFoundResult();
            Story selectedStory = db.Stories.First(p => p.StoryId == id);

            if (selectedStory == null) return new HttpNotFoundResult();
            return View(selectedStory);
        }

        public ActionResult StoryWriting()
        {
            ViewBag.WelcomeMessage = "Welcome to StoryBeeHive. A place to find good stories";
            ViewBag.Message = "Story Writing Tips";

            if (_model == null)
            {
                _model = new Story();
                _model.StoryId = 5;
                _model.Title = "Life Story";
                _model.Description = "Writing about human life";
                _model.Comments = new List<Comment>
                {
                    new Comment {CommentId=1, Description="good story", StoryId=5}
                };
                _model.CategoryId = 1;
                _model.AuthorId = 1;
            }

            if (_model.Comments.Count > 3)
            {
                ViewBag.SubTitle = "Popular Story";
            }

            else
            {
                ViewBag.SubTitle = "New Story";
            }

            if (_model.Description.Length > 50)
            {
                ViewBag.DescriptionLength = "Long Description";
            }

            else
            {
                ViewBag.DescriptionLenth = "Short Description";
            }


            return View();
        }
    }
}