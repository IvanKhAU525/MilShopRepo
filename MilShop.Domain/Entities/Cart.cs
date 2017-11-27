using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilShop.Domain.Entities
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public void AddItem(dynamic goods, int quantity)
        {
            CartLine line = lineCollection
                .Where(g => g.Goods.Id == goods.Id && g.Goods.GetType() == goods.GetType())
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine
                {
                    Goods = goods,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveLine(dynamic goods)
        {
            lineCollection.RemoveAll(l => l.Goods.Id == goods.Id);
        }

        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(e => e.Goods.Price1.Price1 * e.Quantity);

        }
        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<CartLine> Lines
        {
            get { return lineCollection; }
        }
    }

    public class CartLine
    {
        public dynamic Goods { get; set; }
        public int Quantity { get; set; }
    }
}
