﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Dishes.Salad
{
    public class Fruits : ISalad
    {
        public override void GetSalad()
        {
            Console.WriteLine("- Fruits");
        }
    }
}
