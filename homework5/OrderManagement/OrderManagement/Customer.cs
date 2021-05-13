using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    class Customer
    {  
        public string CName { get; set; }
        public Customer(string cname)
        {
            this.CName = cname;
        }
        public override string ToString()
        {
            return CName;
        }
    }
}
