using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StoryBeeHiveWebsite.Models;

namespace StoryBeeHiveWebsite.Controllers
{
    public class AuthorStoryController : Controller
    {
        StoryContext db = new StoryContext();
        // GET: AuthorStory
        public ActionResult Index()
        {
            var authors = db.Authors;
            return View(authors.ToList());
        }

        public ActionResult Details(int? id)
        {
            ViewBag.Message = "Click on 'Show Comments' and Scroll Down to see the Comments on the story";


            if (id == null) return new HttpNotFoundResult();
            Author selectedStory = db.Authors.First(p => p.AuthorId == id);

            if (selectedStory == null) return new HttpNotFoundResult();
            return View(selectedStory);
        }


    }
}