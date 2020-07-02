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
    class ResolutionUpdaterVisitor : IShapeVisitor
    {
        public void Visit(Triangle tri)
        {
            Console.WriteLine("Updated resolution of triangle");
        }

        public void Visit(Circle circ)
        {
            Console.WriteLine("Updated resolution of circle");
        }

        public void Visit(Rectangle rect)
        {
            Console.WriteLine("Updated resolution of rectangle");
        }
    }
}
