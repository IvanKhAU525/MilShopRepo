using MilShop.Domain.Abstract;
using MilShop.Domain.Entities;
using MilShop.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MilShop.WebUI.Controllers
{
    public class CartController : Controller
    {
        private IShopRepository repository;
        public CartController(IShopRepository repo)
        {
            repository = repo;
        }
        public ViewResult CartIndex(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = GetCart(),
                ReturnUrl = returnUrl
            });
        }
        public RedirectToRouteResult AddToCart(int commodityId, string returnUrl)
        {
            object commodityLine = GettingCommodityLine(commodityId);

            if (commodityLine != null)
            {
                GetCart().AddItem(commodityLine, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToRouteResult RemoveFromCart(int commodityId, string returnUrl)
        {
            object commodityLine = GettingCommodityLine(commodityId);

            if (commodityLine != null)
            {
                GetCart().RemoveLine(commodityLine);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        private object GettingCommodityLine(int commodityId)
        {
            string category = (string)TempData["TypeOfCommodity"];
            dynamic commodity = repository.GetType().GetProperty(category).GetValue(repository);
            return ((IEnumerable<dynamic>)commodity).FirstOrDefault(x => x.Id == commodityId);
        }

        public Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }
    }
}
