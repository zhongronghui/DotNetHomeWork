using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : Shape
    {
        public Rectangle(double len ,double w)
        {
            this.Length = len;
            this.Width = w;
        }
    public    double Length { set; get; }
     public   double Width { set; get; }
    public double Area
        {
            get
            {
                if (IsLegal()) 
                {
                    return Length * Width;
                }
                Console.Write("不合法");
                return 0;
            }
        }
    public bool IsLegal() {

            return  Length > 0 && Width > 0;
        }
    public string WhatShape=> $"矩形:len={Length},w={Width}.";
    }
}
