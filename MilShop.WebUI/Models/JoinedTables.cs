using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MilShop.WebUI.Models
{
    public class JoinedTables
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public string Color { get; set; }
        public double Size { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
    }
}