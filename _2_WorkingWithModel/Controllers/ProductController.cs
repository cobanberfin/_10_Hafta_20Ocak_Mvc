using _2_WorkingWithModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2_WorkingWithModel.Controllers
{
    public class ProductController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Product
        public ActionResult Index()
        {
            //List<Categories> c = db.Categories.ToList();
            //List<Products> p = db.Products.ToList();
            //List<Customers> cu = db.Customers.ToList();


            var model = new ProductViewModel
            {
                Clist = db.Categories.ToList(),
                Plist = db.Products.ToList(),
            };

            return View(model);
        }
        public ActionResult Demo()
        {
            return View(model: "Hümeysa Aktaş");
        }
    }
}