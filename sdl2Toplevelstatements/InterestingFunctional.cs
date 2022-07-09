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
            for (int i = 41; i < 640; i += 5)
            {
                var circ = new Circle(new Point2D(0 + i, 200), 40);
                canv?.drawCircle(circ, new Color(255, 140, 25));
                canv?.cUpd();
                canv?.cFill(new Color(140, 146, 172));

            }
            rl(c, canv);
        }
        static private void rl(Circle c, Canvas canv)
        {
            for (int i = 639; i > 1; i -= 5)
            {
                var circ = new Circle(new Point2D(0 + i, 200), 40);
                canv?.drawCircle(circ, new Color(255, 140, 25));
                canv?.cUpd();
                canv?.cFill(new Color(140, 146, 172));
            }
           lr(c, canv);
        }

        public static void pp(Circle c, Canvas canv)
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




        private static CanvasCircle fromLeft2RightBorder = lr;
        private static CanvasCircle fromRight2LeftBorder = rl;
        public static CanvasCircle PingPong = pp;
        


    }
}
