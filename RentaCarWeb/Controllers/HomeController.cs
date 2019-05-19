using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentaCarWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            RentCar.Business.AracBusiness a = new RentCar.Business.AracBusiness();
            a.DBOlustur();

            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Help()
        {
            return View();
        }
        public ActionResult ErrorPage()
        {
            return View();
        }

    }
}