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
    class TranslucentEffect : WindowComponent
    {
        public TranslucentEffect(IWindow window) : base(window)
        {
        }

        public override string GetComponents()
        {
            return Window.GetComponents() + " + Translucent";
        }
    }
}
