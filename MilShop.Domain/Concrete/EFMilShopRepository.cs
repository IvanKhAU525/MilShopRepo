using MilShop.Domain.Abstract;
using MilShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilShop.Domain.Concrete
{
    public class EFMilShopRepository : IShopRepository
    {
        MilShopModel context = new MilShopModel();

        public IEnumerable<Color> Colors { get => context.Colors; }
        public IEnumerable<Size> Sizes { get => context.Sizes; }
        public IEnumerable<Price> Prices { get => context.Prices; }
        public IEnumerable<Sniker> Snikers { get => context.Snikers; }
        public IEnumerable<WinterJacket> WinterJackets { get => context.WinterJackets; }
    }
}
