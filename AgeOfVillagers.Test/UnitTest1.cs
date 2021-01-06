using System;
using Xunit;
using AgeOfVillagers;

namespace AgeOfVillagers.Test
{
    public class UnitTest1
    {
        [Fact]
        public void ArabBedouinTreeCheck()
        {
            bool check = false;

            INation nation = new Arab();
            IComponent component = nation.getComponent("tree");

            Assert.NotNull(component);  //Checks for null

            if (component is ArabBedouinTree)
            {
                check = true;
            }
            Assert.True(check);
        }
        [Fact]
        public void InuitWaterSourceCheck()
        {
            bool check = false;
            INation nation = new Inuit();
            IComponent component = nation.getComponent("water_source");

            Assert.NotNull(component);  //Checks for null
            if (component is NullComponent)
            {
                check = true;
            }
            Assert.True(check);
        }
    }
}
