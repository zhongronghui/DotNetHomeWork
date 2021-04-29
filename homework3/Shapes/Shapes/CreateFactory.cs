using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class CreateFactory
    {

        public static Shape CreateRandomShape(int i)
        {
            Random random = new Random(i);
            int j;
            j = random.Next(0, 3);

            Shape shape = null;
            
                switch (j)
                {
                    case 0:
                        shape = new Square(random.Next(1, 15));
                        Console.Write("正方形"); break;
                    case 1:
                        shape = new Triangle(random.Next(1, 20), random.Next(1, 20), random.Next(1, 20));
                        Console.Write("三角形"); break;
                    case 2:
                        shape = new Rectangle(random.Next(1, 20), random.Next(1, 20));
                        Console.Write("长方形"); break;

                }

            
            return shape;
        }
    }
}

