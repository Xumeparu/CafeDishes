using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Dishes.Main
{
    public class Yogurt : IMain
    {
        public override void GetMain()
        {
            Console.WriteLine("- Yogurt");
        }
    }
}
