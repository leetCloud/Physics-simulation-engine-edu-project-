namespace PhysicsSimulation
{
    internal class Point2D
    {
        internal int X { get;  set; }
        internal int Y{ get;  set; }
        internal Point2D(int x, int y) {X = x; Y = y;}
    }
        

    internal class Vector2D 
    {
        internal float X { get; set; }
        internal float Y { get; set; }
        internal Vector2D(float x, float y) { X = x; Y = y; }
        public static Vector2D operator +(Vector2D v1, Vector2D v2) => new Vector2D(v1.X + v2.X, v1.Y + v2.Y);
        public static Vector2D operator -(Vector2D v1, float c) => new Vector2D(v1.X - c, v1.Y -c);
        public static Vector2D operator *(Vector2D v1,float c) => new Vector2D(v1.X * c, v1.Y * c);
        internal static void VectorVertical(Vector2D v) => v.Y *= -1;
        internal static void VectorHorizontal(Vector2D v) => v.X *= -1;
    }
}
