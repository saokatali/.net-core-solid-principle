using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciple.LSP
{
    public interface IDiscount
    {
        double GetDiscount(int totalSales);
    }
}
