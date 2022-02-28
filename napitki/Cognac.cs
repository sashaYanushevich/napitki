﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napitki
{

    internal class Cognac : AlcoholicDrinks
    {
        private string typeCognac { get; set; }

        public Cognac()
        {
        }

        public Cognac(string name, double volume, double degreeAlcohol, string typeCognac) : base(name, volume, degreeAlcohol)
        {
            this.typeCognac = typeCognac;
        }

        public override void TypeAlcoholicDrink()
        {
            Console.WriteLine($"коньяк: {Name}, тип: {typeCognac}, градус: {DegreeAlcohol}, обьём: {Volume} " );
        }
    }
}
