using System;
namespace DeveloperKataDesign
{
    public class ArsenicTopping : Poison
    {
        public ArsenicTopping(Drink drink) {
           name = "Arsenic";
           boost = -50;
           this.drink = drink;
        }
    }
}