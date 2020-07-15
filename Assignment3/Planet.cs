using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    public abstract class Planet
    {
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        public double Diameter
        {
            get;
        }

        public double Mass
        {
            get;
        }

        public int MoonCount
        {
            get;
        }

        public string Name
        {
            get;
        }

        public double OrbitalPeriod
        {
            get;
        }

        public int RingCount
        {
            get;
        }

        public double RotationPeriod
        {
            get;
        }

        public Planet(string name, double diameter, double mass)
        {
            _name = name;
            _diameter = diameter;
            _mass = mass;
        }

        public override string ToString()
        {
            return "Name: "+Name+"/tDiameter: "+Diameter+"/tMass:"+Mass;
        }
    }
}