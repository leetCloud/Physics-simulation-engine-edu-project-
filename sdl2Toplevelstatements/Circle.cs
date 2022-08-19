using static SDL2.SDL;
namespace PhysicsSimulation
{
    internal class Circle
    {
        public Point2D center;
        private int radius;
        public Circle(Point2D center, int radius)
        {
            this.center = center;
            this.radius = radius;
        }
        internal void DrawCircle(IntPtr renderer)
        {
            var centerX = center.X;
            var centerY = center.Y;
            for (int h = 0; h < radius * 2; h++)
            {
                for (int w = 0; w < radius * 2; w++)
                {
                    
                    var dx = radius - w;
                    var dy = radius - h;

                    if ((dx * dx + dy * dy) <= radius * radius)
                    {
                        SDL_RenderDrawPoint(renderer, centerX + dx, centerY + dy);
                    }
                }
            }
        }
    }
}
