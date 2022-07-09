using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using SDL2;
using sdl2Toplevelstatements;
using static SDL2.SDL;

namespace PhysicsSimulation
{
    public sealed class Canvas
    {
        protected internal IntPtr window { get; set; }
        protected internal IntPtr renderer { get; set; }
            
        internal Canvas(int wh, int hh)
        {

            window = SDL.SDL_CreateWindow
                (
                    $"Frames per second : ---",
                    SDL.SDL_WINDOWPOS_UNDEFINED,
                    SDL.SDL_WINDOWPOS_UNDEFINED,
                    wh,
                    hh,
                    SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN
                 );
            renderer = SDL.SDL_CreateRenderer
                (
                    window,
                    -1,
                    SDL.SDL_RendererFlags.SDL_RENDERER_ACCELERATED |
                    SDL.SDL_RendererFlags.SDL_RENDERER_PRESENTVSYNC
                 );
           
        }
        internal void cUpd() => SDL_RenderPresent(renderer);
        internal void cRemove()
        {
            SDL_DestroyRenderer(renderer);
            SDL_DestroyWindow(window);
            SDL_Quit();
        }
        static internal void cSetColor(Canvas c, Color clr)
        {
            SDL_SetRenderDrawColor(c.renderer, clr.R, clr.G, clr.B, clr.A);
        }
        internal void cFill(Color c)
        {
            cSetColor(this, c);
            SDL.SDL_RenderClear(renderer);
        }
        internal void drawPoint(Point2D p, Color c)
        {
            cSetColor(this, c);
            SDL_RenderDrawPoint(renderer,p.X, p.Y);
        }
        internal void drawCircle(Circle crc, Color c)
        {
            cSetColor(this, c);
            crc.DrawCircle(this.renderer);
        }
        internal void drawRectangle(Rect r1, Color c)
        {
            cSetColor(this, c);
            r1.DrawRectangle(this.renderer);
        }
        internal void drawRectangleP(ImplementedRectangle prect, Color c)
        {
            cSetColor(this, c);
            prect.DrawRectangle(this.renderer);
        }

    }
}   

