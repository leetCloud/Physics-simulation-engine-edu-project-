using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;



namespace PhysicsSimulation
{
    internal class Point2D
    {
        internal int X { get; set; }
        internal int Y { get; set; }
        internal Point2D(int x, int y) { X = x; Y = y; }
    }


    internal class Vector2D
    {
        internal int X { get; set; }
        internal int Y { get; set; }
        internal Vector2D(int x, int y) { X = x; Y = y; }
        internal static Vector2D VectorOfSum(Vector2D v1, Vector2D v2, Vector2D c)
        {
            v1.X = v2.X + c.X;
            v1.Y = v2.Y + c.Y;
            return v1;
        }
        internal static Vector2D VectorOfDifference(Vector2D v1, Vector2D v2, int c)
        {
            v1.X = v2.X - c;
            v1.Y = v2.Y - c;
            return v1;
        }
        internal static Vector2D VectorOfMultiply(Vector2D v1, Vector2D v2, int a)
        {
            v1.X = v2.X * a;
            v1.Y = v2.Y * a;
            return v1;
        }
        internal static void VectorVertical(Vector2D v) => v.Y *= -1;
        internal static void VectorHorizontal(Vector2D v) => v.X *= -1;
    }
}
