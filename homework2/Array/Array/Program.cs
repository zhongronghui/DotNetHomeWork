using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 7, 11, 25, 37, 65, 74, 26 };
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine("最大值" + max);
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    max = array[i];
                }
            }
            Console.WriteLine("最小值" + min);
            int a = 0;
            for (int i = 0; i < array.Length; i++)
            {
                a = a + array[i];
            }
            Console.WriteLine("数组元素总和" + a);
            Double c = a / array.Length;
            Console.WriteLine("数组元素平均值" + c);

        }
    }
}
    

