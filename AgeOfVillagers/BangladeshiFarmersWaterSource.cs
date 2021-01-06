using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace AgeOfVillagers
{
    public class BangladeshiFarmersWaterSource : IComponent
    {
        public Point makePoint(int x,int y)
        {
            return new Point(x, y);
        }
        public void draw(Point p, Graphics g, Pen pen)
        {
            g.DrawLine(pen, makePoint(p.X - 12, p.Y - 8), makePoint(p.X-5, p.Y));
            g.DrawLine(pen, makePoint(p.X - 12, p.Y - 8), makePoint(p.X -5, p.Y - 16));
            g.DrawLine(pen, makePoint(p.X -5, p.Y), p);
            g.DrawLine(pen, p, makePoint(p.X, p.Y - 5));
            g.DrawLine(pen, makePoint(p.X + 5, p.Y), makePoint(p.X + 12, p.Y - 8));
            g.DrawLine(pen, makePoint(p.X + 5, p.Y - 16), makePoint(p.X, p.Y - 11));
            g.DrawLine(pen, makePoint(p.X + 5, p.Y - 16), makePoint(p.X + 12, p.Y - 8));
            g.DrawLine(pen, makePoint(p.X + 5, p.Y), makePoint(p.X, p.Y - 5));
            g.DrawLine(pen, makePoint(p.X, p.Y - 11), makePoint(p.X -5, p.Y - 16));
        }
    }
}
