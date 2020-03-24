using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StoryBeeHiveWebsite.Models;
using System.Data.Entity;
using System.Data.Entity.Migrations;
//using System.Collections.Generic.ICollection;

namespace StoryBeeHiveWebsite.Controllers
{
    public class StoryController : Controller
    {
        StoryContext db = new StoryContext();
        List<Story> _stories = new List<Story>
        {
            
        };

        public DbSet<Story> _storiesList { get; private set; }

        // GET: Story
        public ActionResult Index()
        {
            /*db = new StoryContext();
            
            return View(_storiesList);*/
            var stories = db.Stories.Include(s => s.Author).Include(s => s.Category);
            return View(stories.ToList());
        }

        // GET: Details/id
        public ActionResult Details(int? id)
        {
            ViewBag.Message = "Click on 'Show Comments' and Scroll Down to see the Comments on the story";


            if (id == null) return new HttpNotFoundResult();
            Story selectedStory = db.Stories.First(p => p.StoryId == id);

            if (selectedStory == null) return new HttpNotFoundResult();
            return View(selectedStory);
        }
    }
}