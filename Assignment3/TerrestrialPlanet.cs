using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    public class TerrestrialPlanet : Planet
    {
        private bool _oxygen;

        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) 
            : base(name, diameter, mass)
        {
            _oxygen = oxygen;
        }

        public bool Habitable()
        {
            if (_oxygen == true)
            {
                return true;
            }
             
            return false;
        }

        public bool HasMoons()
        {
            return MoonCount > 0 ? true : false;
        }
    }
}