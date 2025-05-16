namespace Decorator.Core
{
    public class SimpleCoffee : ICoffee
    {
        public string GetDescription() => "Simple Coffee";
        public double GetCost() => 5.0;
    }
}
