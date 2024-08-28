using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    class CoffeeWithHook : CoffeeTemplate
    {
        protected override void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        protected override void BrewCoffeeGrinds()
        {
            Console.WriteLine("Dripping coffee through filter");
        }

        protected override void PourInCup()
        {
            Console.WriteLine("Pouring coffee in cup");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }
    }
}
