using System;

namespace DeveloperKataDesign
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

    public abstract class Poison : Topping
    {
        public override int GetBoost()
        {
            return boost + drink.GetBoost();
        }

        public string Song(){
            const string url = "Run https://www.youtube.com/watch?v=-G3MLjqicC8";
            Console.WriteLine(url);
            return url;
        }

        public override String GetName()
        {
            return name + " " + drink.GetName();
        }
    } 
}
