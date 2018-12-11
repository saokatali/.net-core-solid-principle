using System;

namespace SolidPrinciple.OpenClosed
{
    public class Circle:Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
