using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement2
{
    class Order
    {
        private int _orderNum;//订单编号
        private Customer _customer;//订单客户
        private OrderDetails[] _orderDetails;//订单明细
        private double _sum;
        public Order(int orderNum, Customer customer, OrderDetails[] orderDetails)
        {
            this._orderNum = orderNum;
            OrderNum = orderNum;
            this._customer = customer;
            Customer = customer;
            this._orderDetails = orderDetails;
            OrderDetails = orderDetails;
        }
        public int OrderNum { set; get; }
        public Customer Customer { set; get; }
        public OrderDetails[] OrderDetails { set; get; }
        public double Sum { set; get; }

        public void calculate()                                   //计算订单总金额
        {
            foreach (OrderDetails orderDetails in _orderDetails)
            {
                _sum += (orderDetails.Goods.GoodsPrice) * (orderDetails.GoodsNum);
            }
        }
        public override string ToString()
        {
            StringBuilder details = new StringBuilder();
            foreach (OrderDetails orderItem in _orderDetails)
            {
                details.Append(orderItem.ToString());
            }
            return "\norderNum:" + _orderNum + "     CustomerName:" + _customer.CustomerName + "     Sum:￥" + _sum + details;
        }
        public override bool Equals(object obj)                                                                  //自动生成
        {
            return obj is Order order &&
                   _orderNum == order._orderNum &&
                   EqualityComparer<Customer>.Default.Equals(_customer, order._customer) &&
                   EqualityComparer<OrderDetails[]>.Default.Equals(_orderDetails, order._orderDetails) &&
                   _sum == order._sum;
        }
        public override int GetHashCode()                                                                   //自动生成
        {
            var hashCode = -1839463946;
            hashCode = hashCode * -1521134295 + _orderNum.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Customer>.Default.GetHashCode(_customer);
            hashCode = hashCode * -1521134295 + EqualityComparer<OrderDetails[]>.Default.GetHashCode(_orderDetails);
            hashCode = hashCode * -1521134295 + _sum.GetHashCode();
            return hashCode;
        }
    }
}
