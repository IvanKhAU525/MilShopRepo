using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MilShop.WebUI.Models
{
    public class PageInfo
    {
        public int TotalPages   { get { return (int)Math.Ceiling((decimal)TotalItems / ItemPerPage); } set { } }
        public int TotalItems   { get; set; }
        public int ItemPerPage  { get; set; }
        public int CurrentPage  { get; set; }
        
    }
}