using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrderManagement2
{
    class Customer
    {
        public string _customerName { set; get; }
        public Customer(string name)
        {
            //设置客户姓名
            this._customerName = name;
            CustomerName = name;
        }
        public string CustomerName { set; get; }
        public override string ToString()
        {
            return "customerName:" + _customerName;
        }

    }
}
