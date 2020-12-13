using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Dishes.Dessert
{
    public class Biscuit : IDessert 
    {
        public override void GetDessert()
        {
            Console.WriteLine("- Biscuit");
        }
    }
}
