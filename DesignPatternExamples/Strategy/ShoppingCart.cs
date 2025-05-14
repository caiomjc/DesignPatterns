using Strategy.Strategies.Interface;

namespace Strategy
{
    public class ShoppingCart
    {
        private IPaymentStrategy _paymentStrategy;

        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            _paymentStrategy = strategy;
        }

        public void Checkout(decimal amount)
        {
            if (_paymentStrategy == null)
            {
                throw new InvalidOperationException("Payment strategy not set.");
            }
            _paymentStrategy.Pay(amount);
        }
    }
}
