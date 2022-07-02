using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicsSimulation
{
    delegate void CanvasCircle(Circle cr, Canvas c);
    internal class InterestingFunctional
    {
        private static void lr(Circle c, Canvas canv)
        {
            for (int i = 40; i < 640; i += 5)
            {
                var circ = new Circle(new Point2D(0 + i, 240), 40);
                canv?.drawCircle(circ, new Color(175, 0, 42, 0));
                canv?.cUpd();
                canv?.cFill(new Color(140, 146, 172, 0));

            }
            rl(c, canv);
        }
        static private void rl(Circle c, Canvas canv)
        {
            for (int i = 640; i > 0; i -= 5)
            {
                var circ = new Circle(new Point2D(0 + i, 240), 40);
                canv?.drawCircle(circ, new Color(175, 0, 42, 0));
                canv?.cUpd();
                canv?.cFill(new Color(140, 146, 172, 0));
            }
            lr(c, canv);
        }
        static private void pp(Circle c, Canvas canv)
        {
            while (true)
            {
                switch (c.center.X - 320)
                {
                    case (< 0):
                        InterestingFunctional.fromLeft2RightBorder(c, canv);
                        break;

                    default:
                        InterestingFunctional.fromRight2LeftBorder(c, canv);
                        break;


                }
            }

        }
        public static CanvasCircle fromLeft2RightBorder = lr;
        public static CanvasCircle fromRight2LeftBorder = rl;
        public static CanvasCircle PingPong = pp;

    }
}
