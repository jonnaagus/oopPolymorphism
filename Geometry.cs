using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopPolymorphism
{
    public class Geometry // Base-class (ParentClass)
    {
        public virtual double Area()
        {
            return 0.0; // A general purpose method that returns null. This method can be overridden in derived classes
        }
    }
}
