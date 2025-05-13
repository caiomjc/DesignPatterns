namespace Command.Receivers
{
    public class OrderService
    {
        public void PlaceOrder(string product)
        {
            Console.WriteLine($"Order placed for: {product}");
        }

        public void CancelOrder(string product)
        {
            Console.WriteLine($"Order canceled for: {product}");
        }

        public void SendConfirmation(string product)
        {
            Console.WriteLine($"Confirmation email sent for: {product}");
        }
    }
}
