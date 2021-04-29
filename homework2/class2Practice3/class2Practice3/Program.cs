using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class2Practice3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[100]; //定义数组
            for (int i = 2; i < arr.Length; i++)
            {
                arr[i] = i;
            } //数组元素从2~100
            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    int j, temp;
                    temp = arr[i];
                    for (j = 2 * temp; j < arr.Length; j = j + temp)
                    {
                        arr[j] = 0;
                    }
                    Console.WriteLine(arr[i] + " ");//筛选出素数2~100素数
                }

            }
        }
    }
}