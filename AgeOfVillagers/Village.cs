using System.Collections.Generic;
using System.Drawing;

namespace AgeOfVillagers
{
    public class Village
    {
        public string village_name,nation;
        public List<Point> trees_drawn = new List<Point>();
        public List<Point> houses_drawn = new List<Point>();
        public List<Point> rivers_drawn = new List<Point>();
    }
}
