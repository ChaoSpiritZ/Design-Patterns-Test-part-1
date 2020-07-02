using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. State
             * 2. Composite
             * 3. Proxy <-----
             * 4. Prototype (cloning) + Strategy (sorting)
             * 5. Chain of Responsibility
             * 6. Visitor <-----
             * 7. Observer (or mediator which is better)
             * 8. Builder (or Template Method)
             * 9. Abstract Factory
             * 10. Decorator <-----
             * 11. Memento
             * 12. Template Method ( or Abstract Factory)
             * 13. Adapter
             * 
             * <----- = implemented
             */

            Console.WriteLine("------------------------------------question 3:");

            //-------------question 3:

            //Design Pattern: Proxy

            CarControl CC = new CarControl();
            CarShotgun CS = new CarShotgun(CC);
            CS.DisplayFuel();
            CS.DisplayLocation();

            CC.StartDriving();
            CC.SlowDown(3);
            CC.SpeedUp(15);
            CC.DisplayFuel();
            CS.DisplayFuel();

            //add a full control panel here to control the car but i think that's enough


            Console.WriteLine("------------------------------------question 6:");


            //-------------question 6:

            //Design Pattern: Visitor

            Triangle tri1 = new Triangle(10, 5);
            Circle circ1 = new Circle(3.2);
            Rectangle rect1 = new Rectangle(2.5, 4);

            tri1.Accept(new Printer2DVisitor());
            tri1.Accept(new Printer3DVisitor());
            tri1.Accept(new ResolutionUpdaterVisitor());
            circ1.Accept(new Printer2DVisitor());
            circ1.Accept(new Printer3DVisitor());
            circ1.Accept(new ResolutionUpdaterVisitor());
            rect1.Accept(new Printer2DVisitor());
            rect1.Accept(new Printer3DVisitor());
            rect1.Accept(new ResolutionUpdaterVisitor());




            Console.WriteLine("------------------------------------question 10:");

            //-------------question 10:

            //Design Pattern: Decorator

            IWindow window1 = new BaseWindow(); //empty window
            IWindow window2 = new ColorfulFrameEffect(new FlashingBackgroundEffect(new ShadingEffect(new ThreeDLightingEffect(new TranslucentEffect(new BaseWindow()))))); //all effects
            IWindow window3 = new ShadingEffect(new ColorfulFrameEffect(new BaseWindow())); //some effects

            Console.WriteLine(window1.GetComponents());
            Console.WriteLine(window2.GetComponents());
            Console.WriteLine(window3.GetComponents());
        }
    }
}
