using System;

namespace DeveloperKataDesign.Coffee
{
    public abstract class Topping : Drink
    {
        protected Drink drink;

        public override int GetBoost()
        {
            return boost + drink.GetBoost();
        }

        public override String GetName()
        {
            return name + " " + drink.GetName();
        }
    }
}
