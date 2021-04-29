using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    interface Shape
    {
        double Area { get; }

        string WhatShape { get; }
        bool IsLegal();
    }
}
