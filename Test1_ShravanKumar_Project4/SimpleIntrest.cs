using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_ShravanKumar_Project4
{
    public class SimpleIntrest
    {
        public double RateOfInterest { get; set; }
        public double Time { get; set; }
        public double TotalAmount { get; set; }
        public double Intrest { get; set; }

        public void IntrestCalculation(double _PrincipleAmount)
        {
            Intrest = (_PrincipleAmount * RateOfInterest * Time) / 100;

            TotalAmount = _PrincipleAmount + Intrest;
        }
    }
}
