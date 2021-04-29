using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class2Practice4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 1, 2, 3, 4  },
                             { 5, 1, 2, 3  },
                             { 9 ,5, 1, 2  }
            };
       
            if    ( Isjuzhen(array)){
                Console.WriteLine("是托普利茨矩阵");
            }
            else
            {
                Console.WriteLine("不是托普利茨矩阵");
            }
           
        }
        public static bool Isjuzhen(int[,] array)
        {

            for (int a = 0; a < array.GetLength(0)-1; a++)
            {
                for (int b = 0; b < array.GetLength(1)-1; b++)
                {
                    if (array[a, b] != array[a +1, b + 1]) return false;
                }
            }
            return true;

        }
    }
}

