using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicsSimulation
{       

    internal struct Color
    {
        internal byte R, G, B, A = 0;
        internal Color(byte r, byte g, byte b)
        {
            R = r; B = b; G = g;
        }
        internal enum Pressets
        {
            Red,
            Black,
            White,
            Blue,
            Green,
            Orange,
            Yellow,
            Purple,
        }
        static internal Func<Pressets, Color> ChooseColorPresset = p =>
        {

            switch (p)
            {
                case Pressets.Red:
                    return new Color(255, 25, 25);
                case Pressets.Black:
                    return new Color(0, 0, 0);
                case Pressets.Orange:
                    return new Color(255, 170, 0);
                case Pressets.Blue:
                    return new Color(153, 187, 255);
                case Pressets.Green:
                    return new Color(0, 255, 42);
                case Pressets.White:
                    return new Color(255, 255, 255);
                case Pressets.Yellow:
                    return new Color(255, 255, 0);
                case Pressets.Purple:
                    return new Color(191, 9, 230);
                default:
                    return new Color(0, 0, 0);
            }
        };
    }
}
