using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Dishes.Drink
{
    public class Coffee : IDrink 
    {
        public override void GetDrink()
        {
            Console.WriteLine("- Coffee");
        }
    }
}
