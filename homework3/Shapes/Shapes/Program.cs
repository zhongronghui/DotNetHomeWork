using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            double allArea = 0;
            for (int i = 0; i < 10; i++)
            {
                
                Shape sp =CreateFactory.CreateRandomShape(i);
                
                allArea += sp.Area;
                Console.WriteLine($"{sp.WhatShape} 面积={sp.Area}"  );
               
            }
            Console.WriteLine("十个图形总面积（含不合法图形）为：" + allArea);
        }
    }
}
