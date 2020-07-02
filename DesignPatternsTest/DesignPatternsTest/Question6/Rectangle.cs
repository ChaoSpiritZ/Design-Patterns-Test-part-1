using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTest
{
    /// <summary>
    /// question 6 class
    /// </summary>
    class Rectangle : Shape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        public Rectangle(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }

        public override void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
