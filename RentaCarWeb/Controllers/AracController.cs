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
        public ActionResult AracGrid(string btnLogout)
        {
            if (btnLogout != null)
            {
                Session["loginMusteri"] = 0;
                Response.Redirect(Request.RawUrl);
            }
            return View();
        }
        public ActionResult AracDetails(string btnLogout)
        {
            if (btnLogout != null)
            {
                Session["loginMusteri"] = 0;
                Response.Redirect(Request.RawUrl);
            }
            return View();
        }
    }
}