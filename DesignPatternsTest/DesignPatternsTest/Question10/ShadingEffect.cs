using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTest
{
    /// <summary>
    /// question 10 Class
    /// </summary>
    class ShadingEffect : WindowComponent
    {
        public ShadingEffect(IWindow window) : base(window)
        {
        }

        public override string GetComponents()
        {
            return Window.GetComponents() + " + Shading Effect";
        }
    }
}
