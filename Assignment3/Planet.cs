using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    /**
     * <summary>
     * This abstract class is a blueprint for all Planet
     * </summary>
     * 
     * @class Planet
     */
    public abstract class Planet
    {
        // PRIVATE INSTANCE VARIABLES
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        // PUBLIC PROPERTIES
        public double Diameter
        {
            get { return _diameter; }
        }
        public double Mass
        {
            get { return _mass; }
        }
        public int MoonCount
        {
            get { return _moonCount; }
        }
        public string Name
        {
            get { return _name; }
        }
        public double OrbitalPeriod
        {
            get { return _orbitalPeriod; }
        }
        public int RingCount
        {
            get { return _ringCount; }
        }
        public double RotationPeriod
        {
            get { return _rotationPeriod; }
        }
        // CONSTRUCTOR
        /**
         * <summary>
         * This constructor takes 3 parameters: name, diameter and mass
         * </summary>
         * 
         * @constructor Planet
         */
        public Planet(string name, double diameter, double mass)
        {
            // assign local variable to the fields
            _name = name;
            _diameter = diameter;
            _mass = mass;
        }
        // OVERRIDEN METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * Override the default ToString function
         * </summary>
         * 
         * @override
         * @method ToString
         * @returns {string}
         */
        public override string ToString()
        {
            return "Name: "+Name+"\tDiameter: "+Diameter+"\tMass:"+Mass;
        }
    }
}