using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciple.LSP
{
    public class Enquiry : IDiscount
    {
        public double GetDiscount(int totalSales)
        {
            return totalSales - 5;
        }
    }
}
