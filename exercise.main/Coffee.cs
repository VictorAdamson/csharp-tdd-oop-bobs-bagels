﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{
    public class Coffee : Item
    {
        public Coffee(string SKU, float price, string type, string variant) : base (SKU, price, type, variant)
        {

        }
    }
}
