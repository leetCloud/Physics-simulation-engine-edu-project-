using System;
using System.Net.Http.Headers;
using SDL2;
using System.Threading;
using static SDL2.SDL;
using static PhysicsSimulation.InterestingFunctional;

using sdl2Toplevelstatements;


namespace PhysicsSimulation
{
    internal class Program
    {
        
        readonly static int _ScreenHeight = 640, _ScreenWeight = 480;
        static void Main(string[] args)
        {
            SDL_Event e;
            bool running = true;
            var MyCanvas = new Canvas(_ScreenHeight, _ScreenWeight );

            //Statics:

            MyCanvas?.cFill(new Color(140, 146, 172));
            MyCanvas.cUpd();
            Circle c1 = new Circle(new Point2D(200, 200), 55);
            int dt = 0;
            ImplementedRectangle rectangleP = new ImplementedRectangle(new Vector2D(0, 100), new Vector2D(400, 100), 100, 100);
            //Some Actions:
            
            try 
            {
                while (running)
                {
                    rectangleP.PhysRectMove(rectangleP, dt);
                    if (rectangleP.Start.X + rectangleP.H > _ScreenWeight && rectangleP.Velocity.X > 0)
                        rectangleP.Velocity = new Vector2D(-rectangleP.Velocity.X, rectangleP.Velocity.Y);
                    if (rectangleP.Start.X < 0 && rectangleP.Velocity.X > 0)
                        rectangleP.Velocity = new Vector2D(-rectangleP.Velocity.X, rectangleP.Velocity.Y);
                    if (rectangleP.Start.Y + rectangleP.H > _ScreenHeight && rectangleP.Velocity.X > 0)
                        rectangleP.Velocity = new Vector2D(rectangleP.Velocity.X, -rectangleP.Velocity.Y);
                    if (rectangleP.Start.Y < 0 && rectangleP.Velocity.Y < 0)
                        rectangleP.Velocity = new Vector2D(rectangleP.Velocity.X, -rectangleP.Velocity.Y);

                    MyCanvas.drawCircle(c1, Color.ChooseColorPresset(Color.Pressets.White));
                    MyCanvas.drawRectangleP(rectangleP, Color.ChooseColorPresset(Color.Pressets.Blue));
                    MyCanvas.cUpd();

                }
            }
            catch(Exception err)
            {
                Console.WriteLine(err.Message);
                Console.WriteLine(err.StackTrace);
                Console.WriteLine(err.InnerException);
            }
        }
    }
}
