using StrategyPattern.OperationStrategies.Interfaces;

namespace StrategyPattern.OperationStrategies.Strategies
{
    public class AddStrategy : IOperationStrategy
    {
        public int Calculate(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
