using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Dishes.Salad
{
    public class Veggies : ISalad
    {
        public override void GetSalad()
        {
            Console.WriteLine("- Veggies");
        }
    }
}
