using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    public class GiantPlanet : Planet
    {
        private string _type;

        interface IHasMoons
        {
        }
        interface IHasRings
        {
        }
        public GiantPlanet(string name, double diameter, double mass, string type) 
            : base(name, diameter, mass)
        {
            _type = type;
        }

        public bool HasMoons()
        {
            return MoonCount > 0 ? true : false;
        }

        public bool HasRings()
        {
            return RingCount > 0 ? true : false;
        }
    }
}