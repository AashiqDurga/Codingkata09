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

            var price = checkoutTotalCalculator.CalculateTotalPrice();

            Assert.AreEqual(0, price);
        }
    }
}