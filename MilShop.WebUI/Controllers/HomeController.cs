using MilShop.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MilShop.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IShopRepository rep;

        public HomeController(IShopRepository repository)
        {
            rep = repository;
        }

        public ActionResult Index()
        {
            return View(rep.Goods);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}