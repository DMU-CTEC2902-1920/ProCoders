using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Week24Lab_Views_Controller2View_.Models;

namespace Week24Lab_Views_Controller2View_.Controllers
{
    public class ProductController : Controller
    {
        private List<Product> _products = new List<Product>()
        {
           new Product{ ProductId = 1,
                        Name = "IPhone 6",
                        Colour = "White",
                        Description = "The most expensive smart phone money can buy?",
                        Price = 619.99m},

            new Product{ ProductId = 2,
                        Name = "Lumia 720",
                        Colour = "Black",
                        Description = "It's kind of plastic but works.",
                        Price = 119.99m},

            new Product{ ProductId = 3,
                        Name = "Smasung Galaxy S5",
                        Colour = "Silver",
                        Description = "It's a smartphone. Who cares?",
                        Price = 319.99m},
        };
        // Get: Details/id
        public ActionResult Details(int? id)
        {
            if (id == null) return new HttpNotFoundResult();

            Product selectedProduct = _products.First(p => p.ProductId == id);

            if (selectedProduct == null) return new HttpNotFoundResult();

            Customer customer = new Customer
            {
                CustomerId = 1,
                FirstName = "Bob",
                LastName = "Fossil"
            };

            CustomerProductViewModel viewModel = new CustomerProductViewModel
            {
                Customer = customer,
                Product = selectedProduct
            };

            return View(viewModel);
        }

        // Get: Edit/id
        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpNotFoundResult();
            Product selectedProduct = _products.First(p => p.ProductId == id);
            if (selectedProduct == null) return new HttpNotFoundResult();
            return View(selectedProduct);
        }

        // POST: Edit
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                Debug.WriteLine(product.Name);
                Debug.WriteLine(product.Description);
                Debug.WriteLine(product.Price);
                return RedirectToAction("Index");
            }
            else
            {
                return View(product);
            }
        }


        // GET: Product
        public ActionResult Index()
        {
            return View(_products);
        }
    }
}