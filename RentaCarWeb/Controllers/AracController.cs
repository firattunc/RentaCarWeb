using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentaCarWeb.Controllers
{
    public class AracController : Controller
    {
        // GET: Arac
        public ActionResult AracGrid()
        {
            return View();
        }
        public ActionResult AracDetails()
        {
            RentCar.Business.AracBusiness a = new RentCar.Business.AracBusiness();
            a.DBOlustur();
            return View();
        }
    }
}