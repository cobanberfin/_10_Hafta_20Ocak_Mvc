using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3_PassingDataFormController.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.message = "ViewBag den gelen mesaj";

            ViewData["Mesaj"] = "Viewdatadan gelen mesaj";

            ViewBag.numbers = new[] { 1, 2, 3, 4 };

            TempData["message"] = "TempData dan gelen mesaj";

            //return View();

            return RedirectToAction("Index2"); //bu kodları farklı sayfa da görebilmek için yönlendirdik.

            //Bu yönledirme ile ındex i çalıştırdıktan sonra ındex2 ye ulaşabiliriz. ındex2 den çalıştırdığımızda ulaşamayız.
            //yölnedşrmelerde sadece tempdata verisini kaybetmiyor diğerleri verilerini kaybediyor.
        }

        public ActionResult Index2()
        {
            return View();
        }


    }
}