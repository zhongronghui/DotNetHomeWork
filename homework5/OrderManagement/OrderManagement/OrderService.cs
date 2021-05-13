using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OrderManagement
{
    class OrderService
    {
        private List<Order> orderList = new List<Order>();
        public List<Order> Orders { set; get; }
        public OrderService(){
        }
        public void SortM()                                                 //默认按照订单号排序
        {
              orderList.Sort ((p1, p2) => p1.OrderNum - p2.OrderNum);
        }
        public void Addorder(Order order)
        {
            orderList.Add(order);
        }
        public void Deletorder(int id)
        {
            int i = -1;
            int j = -1;
            try
            {
                foreach (Order order1 in orderList)
                {
                    i++;
                    if (order1.OrderNum == id)
                    {
                        j = i;
                    }
                }
                orderList.RemoveAt(j);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("订单删除失败，请检查输入的订单号!");
            }
        }
        public void Changeorder(Order order , int id)
        {
            int i = -1;
            int j = -1;
            try
            {
                foreach (Order order1 in orderList)
                {
                    i++;
                    if (order.OrderNum == id)
                    {
                        j = i;
                    }
                }
                orderList[j] = order; 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("修改信息失败，请重新输入的订单号!");
            }
        }
        public Order  Findorder(int id)
        {
            return orderList.Where(orderList => orderList.OrderNum == id).FirstOrDefault(); 
        }
        public List<Order> FindorderByname(string cname)
        {
            var query = orderList.Where(o => o.Customer.CName == cname).OrderBy(o => o.Sum);
            return query.ToList();
        }
        
        public void showID()                                                       //输出订单编号
        {
            foreach (Order order in orderList)
            {
                Console.Write(order.OrderNum + " ");
            }
        }
    }
}
