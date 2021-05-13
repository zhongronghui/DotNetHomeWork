using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    class Order
    {
        private int _orderNum;//订单编号
        private Customer _customer;//订单客户
        private OrderDetails[] OrderDetails;//订单明细
        private double _sum;
        public Order(int ordernum, Customer customer, OrderDetails[] orderdetails)
        {
            this.OrderNum = ordernum;
            OrderNum = ordernum;
            this._customer = customer;
            Customer = customer;
            this.OrderDetails = orderdetails;
            OrderDetails = orderdetails;
        }
        public int OrderNum { set; get; }
        public Customer Customer { set; get; }
        public OrderDetails[] orderdetails { set; get; }
        public double Sum { set; get; }

        public void caculate()
        {
            foreach (OrderDetails orderDetails in orderdetails)
            {
                _sum += (orderDetails.Goods.Price) * (orderDetails.GoodsNum);
            }
        }
       
        public override bool Equals(object obj)                                                                  //自动生成
        {
            return obj is Order order &&
                   OrderNum == order.OrderNum &&
                   EqualityComparer<Customer>.Default.Equals(_customer, order._customer) &&
                   EqualityComparer<OrderDetails[]>.Default.Equals(orderdetails, order.orderdetails) &&
                   _sum == order._sum;
        }
        public override int GetHashCode()                                                                   //自动生成
        {
            var hashCode = -1839463946;
            hashCode = hashCode * -1521134295 + orderdetails.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Customer>.Default.GetHashCode(Customer);
            hashCode = hashCode * -1521134295 + EqualityComparer<OrderDetails[]>.Default.GetHashCode(orderdetails);
            hashCode = hashCode * -1521134295 + _sum.GetHashCode();
            return hashCode;
        }
    }
}
