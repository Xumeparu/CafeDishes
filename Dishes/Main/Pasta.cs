using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Dishes.Main
{
    public class Pasta : IMain
    {
        public override void GetMain()
        {
            Console.WriteLine("- Pasta");
        }
    }
}
