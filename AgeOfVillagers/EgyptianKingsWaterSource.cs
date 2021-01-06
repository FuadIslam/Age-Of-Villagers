using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace AgeOfVillagers
{

    public class EgyptianKingsWaterSource : IComponent
    {
        public Point makePoint(int x, int y)
        {
            return new Point(x, y);
        }
        public void draw(Point p, Graphics g, Pen pen)
        {
            g.DrawArc(pen, p.X, p.Y, 12, 12, 0, 360);
        }
    }
}
