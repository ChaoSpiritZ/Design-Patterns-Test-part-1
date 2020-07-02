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
    class ColorfulFrameEffect : WindowComponent
    {
        public ColorfulFrameEffect(IWindow window) : base(window)
        {
        }

        public override string GetComponents()
        {
            return Window.GetComponents() + " + Colorful Frame";
        }
    }
}
