using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入第一个数字：");
            String A = Console.ReadLine();
            Console.Write("输入运算符+，-，*，/其中一个：");
            String B = Console.ReadLine();
            Console.Write("请输入第2个数字：");
            String C = Console.ReadLine();
            Double a, c;
            a = Convert.ToDouble(A);
            c = Convert.ToDouble(C);
            string D="";
            if (B == "+")
            { D = Convert.ToString(a + c); }
            else if (B == "-")
            { D = Convert.ToString(a - c); }
            else if (B == "*")
            { D = Convert.ToString(a * c); }
            else if (B == "/" && c != 0)
            {
                D = Convert.ToString(a / c);
            }
            else
            {
                Console.WriteLine("分母不能为零");
            }

            Console.WriteLine(D);

        }
    }
}
