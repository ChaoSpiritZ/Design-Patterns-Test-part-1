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
    class BaseWindow : IWindow
    {
        public string GetComponents()
        {
            return "Window";
        }
    }
}
