using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Goods goods1 = new Goods(1,"football", 4) ;                                          //测试数据
            Goods goods2 = new Goods(2,"basketball", 3);
            Goods goods3 = new Goods(3,"volleyball", 3);
            Goods goods4 = new Goods(4,"water", 4);
            Goods goods5 = new Goods(5,"chocolate", 5);
            Customer customer1 = new Customer("Z");
            Customer customer2 = new Customer("LIN");
            Customer customer3 = new Customer("xiao");
            OrderDetails orderDetail1 = new OrderDetails(goods1, 2);
            OrderDetails orderDetail2 = new OrderDetails(goods3, 2);
            OrderDetails orderDetail3 = new OrderDetails(goods2, 1);

            OrderDetails[] orderDetails1 = { orderDetail1, orderDetail2 };
            OrderDetails[] orderDetails2 = { orderDetail2, orderDetail3 };
            OrderDetails[] orderDetails3 = { orderDetail1, orderDetail3 };

            Order order1 = new Order(1, customer1, orderDetails1);
       
            Order order2 = new Order(2, customer2, orderDetails2);
       
            Order order3 = new Order(3, customer3, orderDetails3);
  

            OrderService orderService = new OrderService();
            orderService.Addorder(order2);
            orderService.Addorder(order1);
            orderService.Addorder(order3);
            Console.WriteLine("当前保存的订单编号序列");
            orderService.showID();
            Console.Write("默认排序后的订单编号序列: ");
            orderService.SortM();
            orderService.showID();
            Console.WriteLine();
            Console.WriteLine("删除订单编号为3的订单");
            orderService.Deletorder(2);
            Console.Write("当前保存的订单编号序列: ");
            orderService.showID();
            Console.WriteLine("\n");
            Console.WriteLine("查询Z的订单");
            List<Order> porders = orderService.FindorderByname("Z");
            foreach (Order order in porders)
            {
                Console.Write(order);
            }
            Console.ReadKey();

        }
    }
} 
