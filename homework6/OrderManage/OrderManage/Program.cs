using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OrderManagement2
{
    class Program
    {

        static void Main(string[] args)
        {
            Goods goods1 = new Goods("beef", 5);                                          //测试数据
            Goods goods2 = new Goods("carrot", 2);
            Goods goods3 = new Goods("cabbage", 3);
            Goods goods4 = new Goods("water", 1);
            Goods goods5 = new Goods("cola", 3);

            Customer customer1 = new Customer("LIN");
            Customer customer2 = new Customer("Z");
            Customer customer3 = new Customer("zRH");

            OrderDetails orderDetail1 = new OrderDetails(goods1, 1);
            OrderDetails orderDetail2 = new OrderDetails(goods2, 2);
            OrderDetails orderDetail3 = new OrderDetails(goods3, 3);
            OrderDetails orderDetail4 = new OrderDetails(goods4, 4);
            OrderDetails orderDetail5 = new OrderDetails(goods5, 5);

            OrderDetails[] orderDetails1 = { orderDetail1, orderDetail5 };
            OrderDetails[] orderDetails2 = { orderDetail2, orderDetail3 };
            OrderDetails[] orderDetails3 = { orderDetail2, orderDetail3, orderDetail4 };

            Order order1 = new Order(1, customer1, orderDetails1);
            order1.calculate();
            Order order2 = new Order(2, customer2, orderDetails2);
            order2.calculate();
            Order order3 = new Order(3, customer3, orderDetails3);
            order3.calculate();

            OrderService orderService = new OrderService();
            orderService.add(order2);
            orderService.add(order1);
            orderService.add(order3);
            Console.Write("当前保存的订单编号序列: ");
            orderService.showID();
            Console.WriteLine();
            Console.Write("默认排序后的订单编号序列: ");
            orderService.sort();
            orderService.showID();
            Console.WriteLine();
            Console.WriteLine("删除订单编号为3的订单");
            orderService.sub(003);
            Console.Write("当前保存的订单编号序列: ");
            orderService.showID();
            Console.WriteLine("\n");
            Console.WriteLine("查询z的订单");
            List<Order> porders = orderService.querybyCname("LIN");
            foreach (Order order in porders)
            {
                Console.Write(order);
            }
            Console.WriteLine("\n");
            Console.WriteLine("查询购买了carrot的订单");
            List<Order> forders = orderService.querybyGoods("carrot");
            foreach (Order order in forders)
            {
                Console.WriteLine(order);
            }
            Console.ReadKey();
        }
    }
}
