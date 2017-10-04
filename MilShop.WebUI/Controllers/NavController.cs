using MilShop.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MilShop.WebUI.Controllers
{
    public class NavController : Controller
    {
        IShopRepository rep;

        public NavController(IShopRepository repository)
        {
            rep = repository;
        }
        // GET: Nav
        public PartialViewResult Menu(string category)
        {
            IEnumerable<string> categories = rep.GetType().GetProperties()
                                                          .Select(x => x.Name)
                                                          .Where(x => x != "Colors" 
                                                                   && x != "Sizes" 
                                                                   && x != "Prices");

            ViewBag.SelectedCategory = category;

            return PartialView(categories);
        }
    }
}