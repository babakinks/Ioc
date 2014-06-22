using System;
using EssentialTools.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EssentialTools.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Discount_Above_100()
        {
            //arrange
            IDiscountHelper target = getTestObject();
            decimal total = 200;

            //act
            var discountedTotal = target.ApplyDiscount(total);

            //assert
            Assert.AreEqual(total* 0.9M, discountedTotal);
        }

        private IDiscountHelper getTestObject()
        {
            return new MinimumDiscountHelper();
        }
    }
}
