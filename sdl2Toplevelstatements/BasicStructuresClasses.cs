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
        private void info() => Console.Write($"Point2D: X = {X}, Y = {Y}");
        internal int X { get; private set; }
        internal int Y{ get; private set; }
        internal Point2D(int x, int y) {X = x; Y = y;}
        internal Action getInfoAboutPoint2D() => info;
    }
    internal struct Vector2D
    {
        private void info() => Console.Write($"Vector2D: X = {X}, Y = {Y}");

        internal int X { get; set; }
        internal int Y { get; set; }
        internal Vector2D(int x, int y) { X = x; Y = y; }
        internal static Vector2D VectorOfSum(Vector2D v1, Vector2D v2, int c)
        {

            v1.X = v2.X + c;
            v1.Y = v2.Y + c;
            return v1;
        }
        internal static Vector2D VectorOfSubstract(Vector2D v1, Vector2D v2, int c)
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

    }
}
