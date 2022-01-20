using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4_ModelBinding.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //routeConfigte tanımladığım route değişkenlerine atanan verileri RouteData nesnesiyle yakalayabilirim.
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var categoryid = RouteData.Values["categoryid"];
            var name = RouteData.Values["name"];

            var lastname = Request.QueryString["lastname"];
            var productId = Request.QueryString["productid"];

            return Content(string.Format("Controller:{0} - Action:{1} - categoryid:{2} - name:{3}", controller,action,categoryid,name));
        }
    }
}