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
        public ActionResult Index(string btnLogout)
        {
            if (Convert.ToInt32(Session["loginCalisan"]) == 0)
            {
                return RedirectToAction("AdminLogin", "Admin");
            }
            AdminViewModels modelCalisan = new AdminViewModels();
            RentCar.Business.KullaniciBusiness k = new KullaniciBusiness();
            int kullaniciId = Convert.ToInt32( Session["kullaniciId"]);
            Kullanici calisan = k.SelectKullaniciById(kullaniciId);
            modelCalisan.admin = calisan;
            if (btnLogout!=null)
            {
                Session["loginCalisan"] = 0;
                return RedirectToAction("AdminLogin", "Admin");

            }
            return View(modelCalisan);
        }
        public ActionResult GunlukKmSorgu(string btnLogout)
        {
            if (Convert.ToInt32(Session["loginAdmin"]) == 0)
            {
                return RedirectToAction("AdminLogin", "Admin");
            }
            AdminViewModels modelAdmin = new AdminViewModels();
            RentCar.Business.KullaniciBusiness k = new KullaniciBusiness();
            int kullaniciId = Convert.ToInt32(Session["kullaniciId"]);
            Kullanici admin = k.SelectKullaniciById(kullaniciId);
            modelAdmin.admin = admin;
            if (btnLogout != null)
            {
                Session["loginAdmin"] = 0;
                return RedirectToAction("AdminLogin", "Admin");

            }
            return View(modelAdmin);
        }
        public ActionResult GelirGider(string btnLogout)
        {
            if (Convert.ToInt32(Session["loginAdmin"]) == 0)
            {
                return RedirectToAction("AdminLogin", "Admin");
            }
            AdminViewModels modelAdmin = new AdminViewModels();
            RentCar.Business.KullaniciBusiness k = new KullaniciBusiness();
            int kullaniciId = Convert.ToInt32(Session["kullaniciId"]);
            Kullanici admin = k.SelectKullaniciById(kullaniciId);
            modelAdmin.admin = admin;
            if (btnLogout != null)
            {
                Session["loginAdmin"] = 0;
                return RedirectToAction("AdminLogin", "Admin");

            }
            return View(modelAdmin);
        }
        public ActionResult AracTakipOrtalama(string btnLogout)
        {
            if (Convert.ToInt32(Session["loginAdmin"]) == 0)
            {
                return RedirectToAction("AdminLogin", "Admin");
            }
            AdminViewModels modelAdmin = new AdminViewModels();
            RentCar.Business.KullaniciBusiness k = new KullaniciBusiness();
            int kullaniciId = Convert.ToInt32(Session["kullaniciId"]);
            Kullanici admin = k.SelectKullaniciById(kullaniciId);
            modelAdmin.admin = admin;
            if (btnLogout != null)
            {
                Session["loginAdmin"] = 0;
                return RedirectToAction("AdminLogin", "Admin");

            }
            return View(modelAdmin);
        }
        public ActionResult AracTeslim(string btnLogout)
        {
            if (Convert.ToInt32(Session["loginCalisan"]) == 0)
            {
                return RedirectToAction("AdminLogin", "Admin");
            }
            AdminViewModels modelCalisan = new AdminViewModels();
            RentCar.Business.KullaniciBusiness k = new KullaniciBusiness();
            int kullaniciId = Convert.ToInt32(Session["kullaniciId"]);
            Kullanici calisan = k.SelectKullaniciById(kullaniciId);
            modelCalisan.admin = calisan;
            if (btnLogout != null)
            {
                Session["loginCalisan"] = 0;
                return RedirectToAction("AdminLogin", "Admin");

            }
            return View(modelCalisan);
        }
        // GET: Admin
        public ActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminLogin(string kullaniciAd,string kullaniciPassword)
        {
            var kullaniciBusiness = new KullaniciBusiness();
            List<Kullanici> kullanicilar = kullaniciBusiness.listele();

            foreach (var item in kullanicilar)
            {
                if (item.kullaniciAdi==kullaniciAd&&item.sifre==kullaniciPassword)
                {
         
                  
                    Session["kullaniciId"] = item.Id;
                    if (item.role.RoleAd=="admin")
                    {
                        Session["loginAdmin"] = 1;
                        Session["loginCalisan"] = 0;
                        return RedirectToAction("GelirGider", "Admin");
                    }
                    else
                    {
                        Session["loginCalisan"] = 1;
                        Session["loginAdmin"] = 0;
                        return RedirectToAction("Index", "Admin");
                    }
                    
                }
            }

            return View();
        }

    }
}