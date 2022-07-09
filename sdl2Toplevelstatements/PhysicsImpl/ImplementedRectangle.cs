using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDL2;
using static SDL2.SDL;
using System.Collections.Generic;
using System.Collections.Specialized;//?    
using static PhysicsSimulation.Rect;

[assembly: InternalsVisibleTo("PhysicsSimulation")]//Frendly asm.

namespace sdl2Toplevelstatements
{


    internal class  ImplementedRectangle
    {
        internal PhysicsSimulation.Rect rect;
        internal PhysicsSimulation.Vector2D Start { get; set; }
        internal PhysicsSimulation.Vector2D Velocity { get; set; }
        internal int W { get; set; }
        internal int H { get; set; }
        internal ImplementedRectangle(PhysicsSimulation.Vector2D start, PhysicsSimulation.Vector2D vel, int width, int height)
        {

            Velocity = vel;
            W = width;
            H = height;
        }
        
        internal Action<ImplementedRectangle, int> PhysRectMove = (prect, dt) =>
        {
            var dx = new PhysicsSimulation.Vector2D (0,0);
            PhysicsSimulation.Vector2D.VectorOfMultiply(dx, prect.Velocity, dt);
            PhysicsSimulation.Vector2D.VectorOfSum(prect.Start, prect.Start, dx.X);
        };

        internal void DrawRectangle (IntPtr renderer )
        {
            int width = W;
            for (int i = 0; i < W; i++)
            {
                for (int j = 0; j < H; j++)
                {
                    SDL_RenderDrawPoint(renderer, i, j);
                }
            }
        }
    }   
}   
