using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Dishes.Main
{
    public class Porridge : IMain
    {
        public override void GetMain()
        {
            Console.WriteLine("- Porridge");
        }
    }
}
