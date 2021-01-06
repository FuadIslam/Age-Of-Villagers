using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace AgeOfVillagers
{
    public class EgyptianKingsTree : IComponent
    {
        public Point makePoint(int x, int y)
        {
            return new Point(x, y);
        }
        public void draw(Point p, Graphics g, Pen pen)
        {
            g.DrawLine(pen, makePoint(p.X - 5, p.Y + 12), makePoint(p.X, p.Y + 24));
            g.DrawLine(pen, makePoint(p.X + 5, p.Y + 12), makePoint(p.X, p.Y + 24));
            g.DrawLine(pen, makePoint(p.X - 5, p.Y + 12), makePoint(p.X - 8, p.Y + 4));
            g.DrawLine(pen, makePoint(p.X - 5, p.Y + 12), makePoint(p.X - 5, p.Y + 2));
            g.DrawLine(pen, makePoint(p.X - 5, p.Y + 12), makePoint(p.X - 2, p.Y));
            g.DrawLine(pen, makePoint(p.X + 5, p.Y + 2), makePoint(p.X + 5, p.Y + 12));
            g.DrawLine(pen, makePoint(p.X + 2, p.Y), makePoint(p.X + 5, p.Y + 12));
            g.DrawLine(pen, makePoint(p.X + 8, p.Y + 4), makePoint(p.X + 5, p.Y + 12));
        }
    }
}
