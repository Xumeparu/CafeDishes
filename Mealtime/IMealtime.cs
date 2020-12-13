using System;
using System.Collections.Generic;
using System.Text;
using Cafe.Dishes.Main;
using Cafe.Dishes.Salad;
using Cafe.Dishes.Dessert;
using Cafe.Dishes.Drink;

namespace Cafe.Mealtime
{
    public abstract class IMealtime
    {
        public abstract IMain GetMain();
        public abstract ISalad GetSalad();
        public abstract IDessert GetDessert();
        public abstract IDrink GetDrink();
    }
}
