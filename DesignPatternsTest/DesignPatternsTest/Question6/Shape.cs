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
    abstract class Shape : IVisitable
    {
        public abstract void Accept(IShapeVisitor visitor);
    }
}
