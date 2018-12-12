using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciple.LSP
{
    public class Customer : IDatabase, IDiscount
    {
        public double GetDiscount(int totalSales)
        {
            return totalSales - 2;
        }

        public void Save()
        {
            // Database code goes here  
        }
    }
}
