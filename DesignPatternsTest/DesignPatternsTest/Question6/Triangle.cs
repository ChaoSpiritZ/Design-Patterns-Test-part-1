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
    class Triangle : Shape
    {
        public double TriangleBase { get; set; }
        public double Height { get; set; }

        public Triangle(double triangleBase, double height)
        {
            TriangleBase = triangleBase;
            Height = height;
        }

        public override void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
