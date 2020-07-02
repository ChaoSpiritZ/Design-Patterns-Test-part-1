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
    abstract class WindowComponent : IWindow
    {
        public IWindow Window { get; set; }

        public WindowComponent(IWindow window)
        {
            Window = window;
        }

        public abstract string GetComponents();
    }
}
