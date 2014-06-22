using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
    public class MinimumDiscountHelper:IDiscountHelper
    {
        public decimal ApplyDiscount(decimal totalPram)
        {
            if (totalPram > 100)
                return totalPram*0.9M;
            else if (totalPram > 10 && totalPram <= 100)
                return totalPram - 5;
            else
            {
                return totalPram;
            }

        }
    }
}