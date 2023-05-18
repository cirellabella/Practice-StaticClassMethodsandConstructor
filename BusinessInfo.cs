using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_StaticClassMethodsandConstructor
{
    internal static class BusinessInfo
    {
        //static fields
        internal static string _businessName;
        internal static double _taxAmount;

        //static constructor
        static BusinessInfo()
        {
            _businessName = "Happy Days Toys and Sports";
            _taxAmount = 0.08;
        }
    }
}
