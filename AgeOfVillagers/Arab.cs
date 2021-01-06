using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace AgeOfVillagers
{
    public class Arab : INation
    {
        public Color getBackgroundColor()
        {
            return Color.YellowGreen;
        }
        public IComponent getComponent(string component_type)
        {
            if (component_type == "tree")
            {
                return new ArabBedouinTree();
            }
            else if (component_type == "house")
            {
                return new ArabBedouinHouse();
            }
            else
            {
                return new NullComponent();
            }
        }
    }
}
