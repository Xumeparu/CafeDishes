using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Dishes.Dessert
{
    public class Pancake : IDessert
    {
        public override void GetDessert()
        {
            Console.WriteLine("- Pancake");
        }
    }
}
