namespace DeveloperKataDesign
{
    public class WhiskyTopping : Topping
    {
        public WhiskyTopping(Drink drink)
        {
            boost = 10;
            name = "Whisky";
            this.drink = drink;
        }
    }
}
