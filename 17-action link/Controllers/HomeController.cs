using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _17_action_link.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        // esto solo se ejecutara desde una vista, evitando 
        //que el usuario acceda a la vista contacto desde la ruta especifica, 
        //sino permitirla solo  desde una vista con @Html.Action() o Html.RenderAction()
        // 
        [ChildActionOnly] 
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}