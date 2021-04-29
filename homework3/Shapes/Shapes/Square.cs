using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square:Shape
    {
        public Square(double SLen)
        {
            this.SLength = SLen;
        }
        public double SLength { set; get; }
        
        public double Area
        {
            get
            {
                if (IsLegal())
                {
                    return SLength * SLength;
                }
                Console.Write("不合法");
                return 0;
            }
        }
        public bool IsLegal()
        {

            return SLength> 0 ;
        }
        public string WhatShape => $"正方形:Slen={SLength}";
    }
}
