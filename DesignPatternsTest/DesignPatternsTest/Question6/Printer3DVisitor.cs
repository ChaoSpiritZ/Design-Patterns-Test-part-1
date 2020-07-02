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
    class Printer3DVisitor : IShapeVisitor
    {
        public void Visit(Triangle tri)
        {
            Console.WriteLine("Printing triangle in 3d");
        }

        public void Visit(Circle circ)
        {
            Console.WriteLine("Printing circle in 3d");
        }

        public void Visit(Rectangle rect)
        {
            Console.WriteLine("Printing rectangle in 3d");
        }
    }
}
