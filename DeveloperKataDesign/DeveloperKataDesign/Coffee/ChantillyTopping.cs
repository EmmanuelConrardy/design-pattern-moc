namespace DeveloperKataDesign.Coffee
{
    public class ChantillyTopping : Topping
    {
        public ChantillyTopping(Drink drink)
        {
            boost = 3;
            name = "Chantilly";
            this.drink = drink;
        }
    }
}
