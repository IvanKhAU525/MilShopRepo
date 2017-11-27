using MilShop.Domain.Abstract;
using MilShop.WebUI.Models;
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
        private int pageSize = 4;
        private dynamic table;

        public HomeController(IShopRepository repository)
        {
            rep = repository;
            //joinedTables = rep.
        }

        public ActionResult HomeIndex(string category = "Snikers", int page = 1)
        {
            try
            {
                TempData["TypeOfCommodity"] = category;
                table = rep.GetType().GetProperty(category).GetValue(rep);
                MilShopListViewModel model = new MilShopListViewModel()
                {
                    pageInfo = new PageInfo
                    {
                        ItemPerPage = pageSize,
                        CurrentPage = page,
                        TotalItems = (table as IEnumerable<object>).Count()
                    },

                    Table = ((IEnumerable<dynamic>)table).OrderBy(x => x.Id)
                                                         .Skip((page - 1) * pageSize)
                                                         .Take(pageSize),

                    CurrentCategory = category
                };
                return View(model);
            }
            catch (Exception ex)
            {
                return View("Error", ex);
            }
            
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