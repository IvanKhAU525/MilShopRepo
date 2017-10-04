using MilShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MilShop.WebUI.Models
{
    public class MilShopListViewModel
    {
        public IEnumerable<dynamic> Table { get; set; }
        public PageInfo pageInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}