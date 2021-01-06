using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace AgeOfVillagers
{
    public class Egypt : INation
    {
        public Color getBackgroundColor()
        {
            return Color.Yellow;
        }
        public IComponent getComponent(string component_type)
        {
            if (component_type == "tree")
            {
                return new EgyptianKingsTree();
            }
            else if (component_type == "house")
            {
                return new EgyptianKingsHouse();
            }
            else if (component_type == "water_source")
            {
                return new EgyptianKingsWaterSource();
            }
            else
            {
                return new NullComponent();
            }
        }
    }
}
