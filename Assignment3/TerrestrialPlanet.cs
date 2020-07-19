using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    public class TerrestrialPlanet : Planet,IHasMoons,IHabitable
    {
        private bool _oxygen;
        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This constructor takes 4 arguments
         * </summary>
         * 
         * @constructor
         */
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) 
            : base(name, diameter, mass)
        {
            _oxygen = oxygen;
        }
        // the public methods
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