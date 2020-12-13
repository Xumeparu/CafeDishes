using System;
using System.Collections.Generic;
using System.Text;
using Cafe.Dishes.Dessert;
using Cafe.Dishes.Drink;
using Cafe.Dishes.Main;
using Cafe.Dishes.Salad;

namespace Cafe.Mealtime
{
    public class Lunch : IMealtime
    {
        public override IMain GetMain() => new Pasta();
        public override ISalad GetSalad() => new Veggies();
        public override IDessert GetDessert() => new Biscuit();
        public override IDrink GetDrink() => new Compote();
    }
}
