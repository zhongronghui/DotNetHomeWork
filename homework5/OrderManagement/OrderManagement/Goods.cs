using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    public class Goods
    {
        public string GoodName { get; set; }
        public int GoodId { get; set; }
        public double Price { get; set; }
        public Goods(int goodid, string name , double price){
            this.GoodName = name;
            this.Price = price;
            this.GoodId = goodid;
        }

        public override string ToString()
        {
            return "goodsName:" + GoodName + " goodsPrice:" + Price;
        }


    }
}
