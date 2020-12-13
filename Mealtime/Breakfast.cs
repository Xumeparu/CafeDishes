using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using Cafe.Dishes.Main;
using Cafe.Dishes.Salad;
using Cafe.Dishes.Dessert;
using Cafe.Dishes.Drink;

namespace Cafe.Mealtime
{
    public class Breakfast : IMealtime
    {
        public override IMain GetMain() => new Porridge();
        public override ISalad GetSalad() => new Eggs();
        public override IDessert GetDessert() => new Pancake();
        public override IDrink GetDrink() => new Coffee();
    }
}
