using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//求素数因子
namespace Class2Practice1   
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一个数字：");
            String A =  Console.ReadLine();
            int a,b;
            b = 2;
            a = Convert.ToInt32(A);
            while (a >= 2)
            {
                if (a % b == 0)
                {
                    if (a == b) {
                        Console.Write(b+"*");
                            }
                    else
                        Console.Write(b+"*");
                    a = a / b;
            }
                if (a % b != 0)
                    b++;
            }
            
        }
    }
}
