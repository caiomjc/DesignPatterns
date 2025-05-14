using Strategy.Strategies.Interface;

namespace Strategy.Strategies
{
    public class CreditCardPayment(string cardNumber) : IPaymentStrategy
    {
        private readonly string _cardNumber = cardNumber;

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} using Credit Card: {_cardNumber}");
        }
    }
}
