using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace AgeOfVillagers
{
    public class Inuit : INation
    {
        public Color getBackgroundColor()
        {
            return Color.White;
        }
        public IComponent getComponent(string component_type)
        {
            if (component_type == "house")
            {
                return new InuitHuntersHouse();
            }
            else
            {
                return new NullComponent();
            }
        }
    }
}
