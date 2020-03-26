using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoryBeeHiveWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult About()
        {
            
            ViewBag.Motto = "Become a better writer with StoryBeeHive’s creative writing platform.";
            ViewBag.Description = "StoryBeeHive lets anyone make visual stories in seconds. We curate artwork from illustrators around the world and inspire writers of any age to turn those imagesinto original stories.It's a simple idea that has attracted millions of writers, readers, and artists to our platform. Families and friends, teachers and students, and amateurs and professionals have created more than 30 million stories—making StoryBeeHive one of the world's largest storytelling communities.";
            ViewBag.Tips = "You may have learned the basics of story structure in beginning composition class, but here’s a refresher. The story must have a beginning, middle, and end. The character follows a path called the story arc. It begins with an event that sets the wheels in motion. That’s followed by rising action, which means that every step in the story’s progression raises the stakes just a bit, increasing the conflict and tension. Then, the story reaches a climactic turning point. For better or worse, from here forward your character will be changed as a result of his journey through the events. The final piece is the end, or denouement, which wraps the story up in a satisfying way and solidifies both its outcome and its theme.";
            ViewBag.Message = "Welcome to About us page";





            return View();

        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page";
            ViewBag.Text = "TelePhone :";

            return View();
        }

        public ActionResult FAQ()
        {
            ViewBag.Message = "Your FAQ page.";

            return View();
        }
    }
}