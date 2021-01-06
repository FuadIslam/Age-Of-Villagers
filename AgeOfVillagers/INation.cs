using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace AgeOfVillagers
{
    public interface INation
    {
        public Color getBackgroundColor();
        public IComponent getComponent(string component_type);
    }
}
