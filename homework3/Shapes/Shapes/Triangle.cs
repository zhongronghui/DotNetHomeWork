using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle:Shape
    {
        public Triangle(double a,double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        public double A{ set; get; }
        public double B { set; get; }
        public double C { set; get; }


        public double Area
        {
            
            get
            {
                double P = (A + B + C) / 2;
                if (IsLegal())
                {
                    return System.Math.Sqrt(P * (P - A) * (P - B) * (P - C));
                }
                Console.Write("不合法");
                return 0;
            }
        }
        public bool IsLegal()
        {

            return A > 0 && B > 0 && C > 0 && A + B > C && A + C > B && B + C > A;//三角形任意两边之和大于第三边
        
        }
        public string WhatShape => $"三角形:a={A},b={B},c={C}";
    }
}
