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
        public Rect(Point2D start, Point2D end)
        {
            Start= start;
            End= end;
        }
        public static Point2D Start { get;private set; }
        public static Point2D End { get;private set; }
        public Action<IntPtr> DrawRectangle = renderer =>
        {
            for (int i = Start.X; i < End.X; i++)
            {
                for (int j = Start.Y; j < End.Y; j++)
                {
                    SDL_RenderDrawPoint(renderer, i, j);
                }
            }
        };
        
    }
}
