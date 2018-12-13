using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciple.ISP
{
    public class ToyPlane : IToy, IWalkable, IMovable
    {
        public double Price { get; set; }
        public string Color { get; set; }

        public void Move()
        {
            //code related to moving plane
        }

        public void Walk()
        {
            // code related to flying plane
        }
    }
}
