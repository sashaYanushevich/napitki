﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napitki
{
    internal class Lemonade : Drinks
    {
        private string tasteLemonade { get; set; }

        public Lemonade()
        {
        }

        public Lemonade(string tasteLemonade, string name, double volume) : base(name, volume)
        {
            this.tasteLemonade = tasteLemonade;
        }

        public override void TypeDrink()
        {
            Console.WriteLine($" лимонад {Name}, вкус: {tasteLemonade}, обьём: {Volume}");
        }
    }
}
