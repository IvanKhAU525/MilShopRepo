using MilShop.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MilShop.WebUI.Controllers
{
    public class DetailViewController : Controller
    {
        IShopRepository rep;
        // GET: DetailView
        public DetailViewController(IShopRepository repository)
        {
            rep = repository;
        }
        public ActionResult DisplayingDetails(object commodity)
        {

            var model = ((IEnumerable<dynamic>)commodity).Select(x => new
            {
                ModelName = x.ModelName,
                Price = x.Price1.Price1,
                Color = x.Color1.Color1,
                Size = x.Size1.Size1
            });
            return View(model);
        }
    }
}