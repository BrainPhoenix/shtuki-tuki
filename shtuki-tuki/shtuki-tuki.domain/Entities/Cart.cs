using shtuki_tuki.domain.DbProject;
using shtuki_tuki.domain.Enumerables;
using System.Collections.Generic;
using System.Linq;

namespace shtuki_tuki.domain.Entities
{
    public class CartLine
    {
        public virtual Good Goods { get; set; }

        public virtual GoodsPhoto GoodsPhoto { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice { get; set; }
    }

    public class Cart
    {
        private readonly List<CartLine> _lineCollection = new List<CartLine>();
        private readonly ShtukiDbContext _context = new ShtukiDbContext();

        public void AddItem(Good goods, int quantity)
        {
            CartLine line = _lineCollection.FirstOrDefault(g => g.Goods.Id == goods.Id);

            if (line == null)
            {
                _lineCollection.Add(new CartLine
                {
                    GoodsPhoto = _context.GoodsPhotos.FirstOrDefault(
                        el => el.Good.Id == goods.Id && el.TypePhoto == TypePhoto.Avatar),
                    Goods = goods,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void SubItem(Good goods)
        {
            CartLine line = _lineCollection.FirstOrDefault(g => g.Goods.Id == goods.Id);

            if (line?.Quantity > 1)
            {
                line.Quantity -= 1;
            }
        }

        public void RemoveLine(Good goods)
        {
            _lineCollection.RemoveAll(l => l.Goods.Id == goods.Id);
        }

        public decimal ComputeTotalValue()
        {
            return _lineCollection.Sum(e => e.Goods.Price * e.Quantity);
        }

        public void Clear()
        {
            _lineCollection.Clear();
        }

        public IEnumerable<CartLine> Lines
        {
            get { return _lineCollection; }
        }
    }
}