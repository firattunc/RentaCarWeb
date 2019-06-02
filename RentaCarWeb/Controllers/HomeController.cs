using RentaCarWeb.ViewModels.Home;
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
        public ActionResult Index(string btnLogin,string id,string sifre, string btnLogout)
        {
            if (btnLogin!=null)
            {
                using (RentCar.Business.KullaniciBusiness kullaniciBusiness = new RentCar.Business.KullaniciBusiness())
                {
                   
                    foreach (var item in kullaniciBusiness.listele())
                    {
                        if (item.adSoyad==id&&item.sifre==sifre)
                        {
                            Session["loginMusteri"] = 1;
                            Session["musteriId"] = item.Id;
                            Session["musteriAd"] = item.adSoyad;
                            Response.Redirect(Request.RawUrl);
                        }
                    }
                }
            }
            else if (btnLogout!=null)
            {
                Session["loginMusteri"] = 0;
                Response.Redirect(Request.RawUrl);
            }

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