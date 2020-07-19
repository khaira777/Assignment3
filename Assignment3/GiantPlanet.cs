using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    /**
     * <summary>
     * This class is a subclass of the Planet abstract superclass
     * </summary>
     * 
     * @class GiantPlanet
     */
    public class GiantPlanet : Planet,IHasMoons,IHasRings
    {
        private string _type;
        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This constructor takes 4 arguments
         * </summary>
         * 
         * @constructor
         */
        public GiantPlanet(string name, double diameter, double mass, string type) 
            : base(name, diameter, mass)
        {
            _type = type;
        }
        // the public methods
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