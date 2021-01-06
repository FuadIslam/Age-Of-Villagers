using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace AgeOfVillagers
{

    public class InuitHuntersHouse : IComponent
    {
        public Point makePoint(int x, int y)
        {
            return new Point(x, y);
        }
        public void draw(Point p, Graphics g, Pen pen)
        {
            g.DrawArc(pen, p.X, p.Y, 16, 16, 180, 180);
            g.DrawArc(pen, p.X + 5, p.Y + 5, 6, 6, 180, 180);
            g.DrawLine(pen, makePoint(p.X, p.Y + 8), makePoint(p.X+16, p.Y + 8));
        }
    }
}
