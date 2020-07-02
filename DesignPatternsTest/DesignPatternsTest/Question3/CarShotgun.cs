using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTest
{
    /// <summary>
    /// question 3 class, the Proxy
    /// </summary>
    class CarShotgun : IDisplayControls
    {
        public CarControl CarControl { get; set; }

        public CarShotgun(CarControl carControl)
        {
            CarControl = carControl;
        }

        public void DisplayFuel()
        {
            CarControl.DisplayFuel();
        }

        public void DisplayLocation()
        {
            CarControl.DisplayLocation();
        }
    }
}
