using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace AgeOfVillagers
{
    public class BangladeshiFarmersHouse : IComponent
    {
        public Point makePoint(int x, int y)
        {
            return new Point(x, y);
        }
        public void draw(Point p, Graphics g, Pen pen)
        {
            g.DrawLine(pen, p, makePoint(p.X-8,p.Y+8));
            g.DrawLine(pen, p, makePoint(p.X+8,p.Y+8));
            g.DrawLine(pen, makePoint(p.X + 8, p.Y + 8), makePoint(p.X - 8, p.Y + 8));
            g.DrawLine(pen, makePoint(p.X-8,p.Y+16), makePoint(p.X - 8, p.Y + 8));
            g.DrawLine(pen, makePoint(p.X + 8, p.Y + 8), makePoint(p.X + 8, p.Y + 16));
            g.DrawLine(pen, makePoint(p.X - 8, p.Y + 16), makePoint(p.X + 8, p.Y + 16));
        }
    }
}
