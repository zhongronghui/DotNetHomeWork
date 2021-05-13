﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement2
{
    class Goods
    {
        private string _goodsName { set; get; }
        private double _goodsPrice { set; get; }
        public Goods(string name, double price)
        {
            //设置商品名称和价格
            this._goodsName = name;
            GoodsName = name;
            this._goodsPrice = price;
            GoodsPrice = price;
        }
        public string GoodsName { set; get; }
        public double GoodsPrice { set; get; }
        public override string ToString()
        {
            return "goodsName:" + _goodsName + " goodsPrice:" + _goodsPrice;
        }
    }
}
