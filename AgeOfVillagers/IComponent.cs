using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace AgeOfVillagers
{
    public interface IComponent
    {
        public void draw(Point p, Graphics g, Pen pen);
        public Point makePoint(int x, int y);
    }
}
