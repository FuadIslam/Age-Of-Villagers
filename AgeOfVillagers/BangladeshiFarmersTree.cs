using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace AgeOfVillagers
{
    public class BangladeshiFarmersTree : IComponent
    {
        public Point makePoint(int x,int y)
        {
            return new Point(x, y);
        }
        public void draw(Point p, Graphics g, Pen pen)
        {
            g.DrawArc(pen, p.X, p.Y, 16, 16, 0, 360);
            g.DrawLine(pen, makePoint(p.X+6,p.Y+16), makePoint(p.X+10,p.Y+16));
            g.DrawLine(pen, makePoint(p.X + 6, p.Y + 16), makePoint(p.X+6,p.Y+32));
            g.DrawLine(pen, makePoint(p.X + 10, p.Y + 32), makePoint(p.X + 10, p.Y + 16));
            g.DrawLine(pen, makePoint(p.X + 6, p.Y + 32), makePoint(p.X + 10, p.Y + 32));
        }
    }
}
