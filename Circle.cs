using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopPolymorphism
{
    public class Circle : Geometry // Circle-class inherits from the Geometry-class
    {
        private double Radius { get; set; }
        public Circle()
        {
            Radius = 5; // Declare a value to the Radius-variable
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius; // Calculates and returns the area of the circle using pi * radius^2
        }
    }
}
