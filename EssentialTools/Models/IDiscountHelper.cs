using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialTools.Models
{
    public interface IDiscountHelper
    {
        decimal ApplyDiscount(decimal totalPram);
    }

    public class DefaultDiscountHelper : IDiscountHelper
    {
        public decimal DiscountSize { get; set; }
        public decimal ApplyDiscount(decimal totalPram)
        {
            return (totalPram - (DiscountSize / 100m * totalPram));
        }
    }
}
