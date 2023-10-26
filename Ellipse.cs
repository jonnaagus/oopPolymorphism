using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopPolymorphism
{
    public class Ellipse : Geometry // Ellipse-class inherits from the Geometry-class
    {
        private double Bigaxis { get; set; }
        private double Smallaxis { get; set; }

        public Ellipse()
        {
            Bigaxis = 3; // Declares a value to the bigaxis and smallaxis variables
            Smallaxis = 2;
        }

        public override double Area()
        {
            return Math.PI * Bigaxis * Smallaxis; // Calculates and returns the area of the ellips using pi * bigaxis * smallaxis
        }

    } 
}
