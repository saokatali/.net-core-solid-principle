using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciple.ISP
{
    public class ToyHouse : IToy
    {
        public double Price { get; set; }
        public string Color { get; set ; }
    }
}
