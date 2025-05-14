using Strategy.Strategies.Interface;

namespace Strategy.Strategies
{
    public class PayPalPayment(string email) : IPaymentStrategy
    {
        private readonly string _email = email;

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} using PayPal account: {_email}");
        }
    }
}
