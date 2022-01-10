using StrategyPattern.OperationStrategies.Interfaces;

namespace StrategyPattern.OperationStrategies
{
    public class OperationContext : IOperationContext
    {
        private IOperationStrategy _strategy;

        public void SetStrategy(IOperationStrategy strategy)
        {
            _strategy = strategy;
        }

        public int ExecuteStrategy(int firstNumber, int secondNumber)
        {
            return _strategy.Calculate(firstNumber, secondNumber);
        }
    }
}
