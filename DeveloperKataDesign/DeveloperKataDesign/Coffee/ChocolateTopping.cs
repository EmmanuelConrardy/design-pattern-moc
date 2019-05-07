namespace DeveloperKataDesign
{
    public class ChocolateTopping : Topping
    {
        public ChocolateTopping(Drink drink)
        {
            boost = 5;
            name = "Chocolate";
            this.drink = drink;
        }
    }
}
