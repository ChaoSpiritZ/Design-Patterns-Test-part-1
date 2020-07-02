using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTest
{
    /// <summary>
    /// question 6 interface
    /// </summary>
    interface IShapeVisitor
    {
        void Visit(Triangle tri);
        void Visit(Circle circ);
        void Visit(Rectangle rect);
    }
}
