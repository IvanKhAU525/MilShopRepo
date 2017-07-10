using MilShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilShop.Domain.Abstract
{
    public interface IShopRepository
    {
        IEnumerable<Commodity> Goods { get; }
    }
}
