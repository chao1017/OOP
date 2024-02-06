using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass101
{
    internal abstract class Shape
    {
        // Abstract method with no implementation.
        // subclasses must provide an implementation.
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
}
