using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTest
{
    /// <summary>
    /// question 3 class
    /// </summary>
    class CarControl : IDisplayControls //can also inherit from an interface that has the rest of the methods
    {
        public int Kph { get; set; }
        public int Fuel { get; set; }

        public CarControl()
        {
            Kph = 0;
            Fuel = 100;
        }

        public void StartDriving()
        {
            if (Kph == 0)
            {
                if(Fuel >= 20)
                {
                    Kph = 5;
                    Fuel -= 20;
                    Console.WriteLine($"Started driving! speed: {Kph}");
                }
                else
                {
                    Console.WriteLine("Not enough fuel to start driving!");
                }
            }
            else
            {
                Console.WriteLine($"You are already driving! speed: {Kph}");
            }
        }

        public void StopDriving()
        {
            Kph = 0;
            Console.WriteLine($"Stopped driving! speed: {Kph}");
        }

        public void SpeedUp(int increaseBy)
        {
            if (increaseBy > 0)
            {
                if (Fuel >= 20)
                {
                    Kph += increaseBy;
                    Fuel -= 20;
                    Console.WriteLine($"Speeding up by {increaseBy} Kph! speed: {Kph}");
                }
                else
                {
                    Console.WriteLine("Not enough fuel to speed up!");
                }
            }
        }

        public void SlowDown(int decreaseBy)
        {
            if (decreaseBy > 0 && decreaseBy < Kph)
            {
                if (Fuel >= 20)
                {
                    Kph -= decreaseBy;
                    Fuel -= 20;
                    Console.WriteLine($"Slowing down by {decreaseBy} Kph! speed: {Kph}");
                }
                else
                {
                    Console.WriteLine("Not enough fuel to slow down!");
                }
            }
            else
                Console.WriteLine($"Could not slow down by {decreaseBy} Kph!");
        }

        public void TurnRight()
        {
            if (Fuel >= 20)
            {
                Console.WriteLine("Turning right!");
            }
            else
            {
                Console.WriteLine("Not enough fuel to turn right!");
            }
        }

        public void TurnLeft()
        {
            if (Fuel >= 20)
            {
                Console.WriteLine("Turning left!");
            }
            else
            {
                Console.WriteLine("Not enough fuel to turn left!");
            }
        }

        public void DisplayFuel()
        {
            Console.WriteLine($"Fuel: {Fuel}");
        }

        public void DisplayLocation()
        {
            Console.WriteLine("You are in the middle of nowhere!");
        }
    }
}
