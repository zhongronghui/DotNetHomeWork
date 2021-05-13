using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    class OrderDetails
    {
        public Goods Goods { get; set; }
        public int GoodsNum { get; set; }
        public OrderDetails(Goods goods ,int goodsnum)
        {
            this.Goods = goods;
            this.GoodsNum = goodsnum;
        }
        public double sum
        {
            get => Goods.Price * GoodsNum;
        }
        public override int GetHashCode()
        {
            var hashCode = -1839463946;
            hashCode = hashCode * -1521134295 + EqualityComparer<Goods>.Default.GetHashCode(Goods);
            hashCode = hashCode * -1521134295 + GoodsNum.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return "\nGoodsname:" +  Goods.GoodName+ "\ngoodsNum:" + GoodsNum + "\nPrice:" + Goods.Price + "\n";
        }
    }
}
