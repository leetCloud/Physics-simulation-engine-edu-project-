using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Drawing;
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
                    $"",
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
        internal void Upd() => SDL_RenderPresent(renderer);
        internal void Remove()
        {
            SDL_DestroyRenderer(renderer);
            SDL_DestroyWindow(window);
            SDL_Quit();
        }
        internal void SetColor(Canvas c, Color clr)
        {
            SDL_SetRenderDrawColor(c.renderer, clr.R, clr.G, clr.B, clr.A);
        }

        internal void draw2d(Vector2D Vp, Color color)
        {
            SetColor(this, color);
            SDL_RenderDrawPoint(this.renderer, Vp.X, Vp.Y);
        }
        internal void Fill(Color c)
        {
            SetColor(this, c);
            SDL.SDL_RenderClear(renderer);
        }
        internal void MDrawVector(Vector2D p, Color c)
        {
            SetColor(this, c);
            SDL_RenderDrawPoint(renderer, p.X, p.Y);
        }
        internal void MDrawCircle(Circle crc, Color c)
        {
            SetColor(this, c);
            crc.DrawCircle(this.renderer);
        }

        internal void MSetTitle(string title) => SDL_SetWindowTitle(this.window, title);
        internal void MDrawRectangleP(Rect prect, Color c)
        {
            Vector2D end = new Vector2D(prect.topleft.X + prect.bottomright.X, prect.bottomright.Y + prect.topleft.Y);
            Vector2D pVector2D = new Vector2D(0, 0);
            for (pVector2D.Y = prect.topleft.Y; pVector2D.Y < end.Y; pVector2D.Y++)
            {
                for (pVector2D.X = prect.topleft.X; pVector2D.X < end.X; pVector2D.X++)
                    draw2d(pVector2D, c);
            }
        }

        internal void DrawPhysRect(PhysicalRect r)
        {
            Vector2D end = new Vector2D(r.bottomright.X + r.topleft.X, r.bottomright.Y + r.topleft.Y);
            Vector2D pVector2D = new Vector2D(0, 0);
            for (pVector2D.Y = r.topleft.Y; pVector2D.Y < end.Y; pVector2D.Y++)
            {
                for (pVector2D.X = r.topleft.X; pVector2D.X < end.X; pVector2D.X++)
                {
                    draw2d(pVector2D, Color.ChooseColorPresset(Color.Pressets.Yellow));
                }
            }

        }


    }
}
