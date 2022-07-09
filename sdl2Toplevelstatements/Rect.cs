using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using SDL2;
using static SDL2.SDL;

namespace PhysicsSimulation
{


    internal class Rect
    {
        public Rect(Vector2D start, int width, int height)
        {
            Start = start;
            Width = width;
            Height = height;
        }
        public static int Width { get;private set; }
        public static int Height { get;private set; }
        public static Vector2D Start { get;private set; }
        public Action<IntPtr> DrawRectangle = renderer =>
        {
            for (int i = Start.X; i < Width; i++)
            {
                for (int j = Start.Y; j < Height; j++)
                {
                    SDL_RenderDrawPoint(renderer, i, j);
                }
            }
        };
        
    }
}
