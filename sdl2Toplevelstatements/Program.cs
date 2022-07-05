using System;
using SDL2;
using static SDL2.SDL;
using static PhysicsSimulation.InterestingFunctional;
//SDL2 via Top-level statements;

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
            MyCanvas?.cFill(Color.ChooseColorPresset(Color.Pressets.White));
            
            //Some Actions:
            try
            {
                while (running)
                {
                    InterestingFunctional.PingPong(new Circle(new Point2D(0, 240), 40), MyCanvas);
                    
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
