using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
    public class FlexibleDiscountHelper: IDiscountHelper
    {
        public decimal ApplyDiscount(decimal totalPram)
        {
            decimal discount = totalPram > 100 ? 70 : 25;
            return (totalPram - (discount/100m*totalPram));
        }
    }
}