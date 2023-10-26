using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopPolymorphism
{
    public class Square : Geometry // Square-class iherits from the Geometry-class
    {
        private double Side { get; set; }
        public Square()
        {
            Side = 8; // Declares a value to the side-variable
        }

        public override double Area()
        {
            return Side * Side; // Calculates and return the area of the square using side^2

        }
    }
}
