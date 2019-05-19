using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentaCarWeb.ViewModels.Admin;
using RentCar.Business;
using RentCar.Entities;

namespace RentaCarWeb.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MusteriSorgu()
        {
            return View();
        }
        public ActionResult SirketEkle()
        {
            return View();
        }
        public ActionResult AracEkle()
        {
            
            return View();
        }
        // GET: Admin
        public ActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminLogin(string kullaniciAd,string kullaniciPassword)
        {
            AdminViewModels model = new AdminViewModels();
            var kullaniciBusiness = new KullaniciBusiness();
            List<Kullanici> adminler = kullaniciBusiness.SelectAllKullaniciByRoleId(2);

            foreach (var item in adminler)
            {
                if (item.kullaniciAdi==kullaniciAd&&item.sifre==kullaniciPassword)
                {
                    model.admin = item;
                    Session["loginDurum"] = 1;
                    Session["admin"] = item;
                    Session["adminId"] = item.Id;
                    return RedirectToAction("Index", "Admin");
                }
            }

            return View();
        }

    }
}