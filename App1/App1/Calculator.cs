using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class Calculator
    {
        double Total;
        int Tip;
        double grandTotal = -1.0;

        public double GrandTotal
        {
            get
            {
                if (grandTotal == -1.0)
                    grandTotal = Total * (Tip / 100.0 + 1);
                return Math.Round(grandTotal,2);
            }
        }

        public Calculator(double total, int tip, bool excludeHst)
        {
            Total = total;
            Tip = tip;
            if (excludeHst)
                Total /= 1.13;
        }
    }
}
