// See https://aka.ms/new-console-template for more information
using Strategy.Strategies;
using Strategy;

Console.WriteLine("Strategy pattern example!");

var cart = new ShoppingCart();

// Using Credit Card
cart.SetPaymentStrategy(new CreditCardPayment("1234-5678-9876-5432"));
cart.Checkout(100.00m);

// Using PayPal
cart.SetPaymentStrategy(new PayPalPayment("user@example.com"));
cart.Checkout(250.00m);
