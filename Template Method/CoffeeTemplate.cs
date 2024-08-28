using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    abstract class CoffeeTemplate
    {
        public void PrepareCoffee()
        {
            BoilWater();
            BrewCoffeeGrinds();
            PourInCup();
            AddCondiments();
        }

        protected abstract void BoilWater();
        protected abstract void BrewCoffeeGrinds();
        protected abstract void PourInCup();
        protected abstract void AddCondiments();
    }
}
