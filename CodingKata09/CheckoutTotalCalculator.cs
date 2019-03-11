namespace Checkout
{
    public class CheckoutTotalCalculator
    {
        public decimal CalculateTotalPrice(string itemName)
        {
            if (itemName == "A")
            {
                return 50.00M;
            }
            return 0;
        }
    }
}