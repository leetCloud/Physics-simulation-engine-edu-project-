using System;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using SDL2;
using System.Threading;
using sdl2Toplevelstatements;

namespace PhysicsSimulation
{


    internal class Program
    {
        //Models:
        public static Vector2D myVector2D = new Vector2D(100, 100);

        ////Fields:
        private readonly static int _ScreenHeight = 640, _ScreenWeight = 480;

        private const float fps = 60;
        static void Main(string[] args)
        {
            Canvas MyCanvas = null;
            try
            {
                MyCanvas = new Canvas(640, 480);
                PhysicalRect r2 = new PhysicalRect(new Vector2D(100, 80), new Vector2D(200, 160), new Vector2D(10, 10));
                var dt = 0;
                MyCanvas.DrawPhysRect(r2);

                while (true)
                {
                    MyCanvas.Upd();

                    var t0 = SDL.SDL_GetTicks();
                    (r2 as IMovable).Move(1);//try int


                    MyCanvas.Fill(Color.ChooseColorPresset(Color.Pressets.Black));
                    MyCanvas.DrawPhysRect(r2);


                    MyCanvas.Upd();

                    var t1 = SDL.SDL_GetTicks();
                    dt = (int)(t1 - t0) / 1000;

                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                Console.WriteLine(err.StackTrace);
                Console.WriteLine(err.InnerException);
            }
            finally
            {
                MyCanvas.Remove();
            }
        }
    }
}
