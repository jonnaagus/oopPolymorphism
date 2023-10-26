using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopPolymorphism
{
    public class Parallellogram : Geometry // Parallellogram-class inherits from the Geometry-class
    {
        private double Base { get; set; }
        private double Height { get; set; }

        public Parallellogram()
        {
            Base = 9; // Declares a value to the base and height variables 
            Height = 6;
        }

        public override double Area()
        {
            return Base * Height; // Calculates and returns the area of the parallellogram using base * height
        }
    }
}
