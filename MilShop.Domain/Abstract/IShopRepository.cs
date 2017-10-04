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
        IEnumerable<Color> Colors { get; }
        IEnumerable<Size> Sizes { get; }
        IEnumerable<Price> Prices { get; }
        IEnumerable<Sniker> Snikers { get; }
        IEnumerable<WinterJacket> WinterJackets { get; }
    }
}
