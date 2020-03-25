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
    }
}