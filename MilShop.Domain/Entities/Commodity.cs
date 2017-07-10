using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilShop.Domain.Entities
{
    public class Commodity
    {
        public Int32 CommodityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Size { get; set; }
    }
}
