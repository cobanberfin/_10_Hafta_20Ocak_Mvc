using _5_MvcCrud.Models;
using _5_MvcCrud.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5_MvcCrud.Controllers
{
    public class CategoriesController : Controller
    {
        NorthwindEntities2 db =  new NorthwindEntities2();
        CategoriesModel model = new CategoriesModel();

        // GET: Categories
        
        public ActionResult Liste(string name)
        {
            if(name == null)
            {
                name ="";
            }
            model.clist = db.Categories.Where(x => x.CategoryName.Contains(name)).ToList();
            return View(model);
        }
        public ActionResult Detay(int id)
        {
            model.categories = db.Categories.Find( id);
                return View(model);
        }
        public ActionResult Guncel(int id)
        {
            model.categories = db.Categories.Find(id);//listeyı al önce

            return View(model);
        }
    }
}