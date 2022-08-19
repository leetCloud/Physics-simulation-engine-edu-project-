using System.Xml;
using sdl2Toplevelstatements;

namespace PhysicsSimulation
{
    internal class Rect
    {
        public Rect(Vector2D tl, Vector2D br)
        {
            topleft = tl;
            bottomright = br;
        }
        internal void RectInfo() => Console.Write($"{this.topleft.X}, {this.topleft.Y}, {this.bottomright.X}, {this.bottomright.Y}");
        internal Vector2D topleft { get; set; }
        internal Vector2D bottomright { get; set; }
    }

    internal class PhysicalRect :  Rect, IMovable
    {
        private Vector2D _velocity;
        internal Vector2D topleft { get; set; }
        internal Vector2D bottomright { get; set; }
        void IMovable.Move(float dt)
        {
            Vector2D dx = new Vector2D(0, 0);
            dx = _velocity * dt;
            topleft += dx;
            if (this.topleft.X + this.bottomright.X > Universe.rb && this._velocity.X > 0.0)
                Vector2D.VectorHorizontal(this._velocity);
            if (this.topleft.X < Universe.lb && this._velocity.X < 0.0)
                Vector2D.VectorHorizontal(this._velocity);
            if (this.topleft.Y + this.bottomright.Y > Universe.bb && this._velocity.Y > 0.0)
                Vector2D.VectorVertical(this._velocity);
            if (this.topleft.Y < Universe.tb && this._velocity.Y < 0.0)
                Vector2D.VectorVertical(this._velocity);
        }
        internal void RectInfo()
        {   
            base.RectInfo();
            Console.Write($" Velocity: { this._velocity.X}, {this._velocity.Y}");
        }
        internal PhysicalRect(Vector2D br, Vector2D tl, Vector2D vel) : base(br, tl)
        {
            bottomright = br;
            topleft = tl;
            _velocity = vel;
        }
    }
}
