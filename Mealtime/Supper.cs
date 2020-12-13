using System;
using System.Collections.Generic;
using System.Text;
using Cafe.Dishes.Dessert;
using Cafe.Dishes.Drink;
using Cafe.Dishes.Main;
using Cafe.Dishes.Salad;


namespace Cafe.Mealtime
{
    public class Supper : IMealtime
    {
        public override IMain GetMain() => new Yogurt();
        public override ISalad GetSalad() => new Fruits();
        public override IDessert GetDessert() => new Cake();
        public override IDrink GetDrink() => new Tea();
    }
}
