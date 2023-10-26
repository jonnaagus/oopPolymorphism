using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopPolymorphism
{
    public class Rectangle : Geometry // Rectangle-class inherits from the Geometry-class
    {
        private double Lenght { get; set; }
        private double Width { get; set; }

        public Rectangle()
        {
            Lenght = 5; // Declares values to the lenght and width variables
            Width = 3;
        }
        public override double Area()
        {
            return Lenght * Width; // Calculates and returns the area of the rectangle using lenght * width 
        }
    }
}
