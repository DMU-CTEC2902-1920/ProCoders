using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StoryWebsiteMVCProject.Models;

namespace StoryWebsiteMVCProject.Controllers
{
    
    public class ShopController : Controller
    {
        private ProductModel _model;
        public ShopController() { }
        public ShopController(ProductModel model)
        {
            _model = model;
        }

        // GET: Shop
        public ViewResult Index()
        {
            ViewBag.Title = "The Shop";
            ViewBag.WelcomeMessage = "Welcome to the Shop. Kindly spend all your money!";
            ViewData["CurrentTime"] = DateTime.Now;
            return View();
        }

        public ViewResult Product()
        {
            if (_model == null)
            {
                _model = new ProductModel();
                _model.Name = "IPhone 6";
                _model.Description = "Latest IPhone with things that make it better.";
                _model.Price = 350.00m;
            }

            ViewBag.Title = "Product: IPhone 6";

            if (_model.Price > 200)
            {
                ViewBag.SubTitle = "Bling!";
            }

            else
            {
                ViewBag.SubTitle = "Cheap and nasty product!";
            }

            return View(_model);
        }

        public string Product1(string Type, string Colour)
        {
            return String.Format("Product Type = {0}, Colour = {1}", Type, Colour);
        }

        public string Product2(int id)
        {
            return "Product : Id = " + id.ToString();
        }

        public string Product3()
        {
            return "Shop product";
        }

        public RedirectResult DVD()
        {
            return RedirectPermanent("~/shop/product1?type=shirt&colour=blue");
            //return Redirect("~/Shop/Product1?type=22&colour=44");
        }
    }
}