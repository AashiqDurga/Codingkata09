using System;
using Checkout;
using NUnit.Framework;

namespace Tests
{
    public class PricingTests
    {
        /*
            assert_equal(  0, price(""))
    assert_equal( 50, price("A"))
    assert_equal( 80, price("AB"))
    assert_equal(115, price("CDBA"))
        */

        [Test]
        public void WHEN_Pricing_No_Item_THEN_Total_Is_0()
        {
            var checkoutTotalCalculator = new CheckoutTotalCalculator();

            var price = checkoutTotalCalculator.CalculateTotalPrice(string.Empty);

            Assert.AreEqual(0, price);
        }

        [TestCase("A", 50.0)]
        public void WHEN_Pricing_Single_Item_THEN_Checkout_Total_Is_Equal_To_Price_Of_That_Item(string itemName, decimal expectedPrice)
        {
            var checkoutTotalCalculator = new CheckoutTotalCalculator();

            var price = checkoutTotalCalculator.CalculateTotalPrice(itemName);

            Assert.AreEqual(expectedPrice, price);
        }
    }
}