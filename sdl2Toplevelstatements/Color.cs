﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicsSimulation
{       
    internal class Color
    {
        public byte R, G, B, A;
        public Color(byte r, byte g, byte b, byte a)
        {
            R = r; G = g; B = b; A = a;
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
                    return new Color(255, 25, 25, 0);
                case Pressets.Black:
                    return new Color(0, 0, 0, 0);
                case Pressets.Orange:
                    return new Color(255, 170, 0, 0);
                case Pressets.Blue:
                    return new Color(25, 25, 255, 0);
                case Pressets.Green:
                    return new Color(0, 255, 42, 0);
                case Pressets.White:
                    return new Color(255, 255, 255, 0);
                case Pressets.Yellow:
                    return new Color(255, 255, 0, 0);
                case Pressets.Purple:
                    return new Color(191, 9, 230, 0);
                default:
                    return new Color(0, 0, 0, 0);
            }
        };

    }
}