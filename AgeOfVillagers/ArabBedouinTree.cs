using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace AgeOfVillagers
{
    public class ArabBedouinTree : IComponent
    {
        public Point makePoint(int x, int y)
        {
            return new Point(x, y);
        }
        public void draw(Point p, Graphics g, Pen pen)
        {
            g.DrawLine(pen, p, makePoint(p.X,p.Y-12));
            g.DrawLine(pen, makePoint(p.X-2,p.Y-12), makePoint(p.X+2,p.Y-12));
            g.DrawLine(pen, makePoint(p.X - 2, p.Y - 12), makePoint(p.X - 2, p.Y));
            g.DrawLine(pen, makePoint(p.X - 2, p.Y), makePoint(p.X + 2, p.Y ));
            g.DrawLine(pen, makePoint(p.X + 2, p.Y - 12), makePoint(p.X + 2, p.Y));
            g.DrawLine(pen, makePoint(p.X-8,p.Y-24), makePoint(p.X,p.Y-12));
            g.DrawLine(pen, makePoint(p.X-4,p.Y-24), makePoint(p.X, p.Y - 12));
            g.DrawLine(pen, makePoint(p.X+4, p.Y - 24), makePoint(p.X, p.Y - 12));
            g.DrawLine(pen, makePoint(p.X+8, p.Y - 24), makePoint(p.X, p.Y - 12));
        }
    }
}
