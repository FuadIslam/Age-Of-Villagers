using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class Bangladesh : INation
    {
        public Color getBackgroundColor()
        {
            return Color.LightGreen;
        }
        public IComponent getComponent(string component_type)
        {
            if (component_type == "tree")
            {
                return new BangladeshiFarmersTree();
            }
            else if (component_type == "house")
            {
                return new BangladeshiFarmersHouse();
            }
            else if (component_type == "water_source")
            {
                return new BangladeshiFarmersWaterSource();
            }
            else
            {
                return new NullComponent();
            }
        }
    }
}
