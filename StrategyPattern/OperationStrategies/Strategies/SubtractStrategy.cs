using StrategyPattern.OperationStrategies.Interfaces;

namespace StrategyPattern.OperationStrategies.Strategies
{
    public class SubtractStrategy : IOperationStrategy
    {
        public int Calculate(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}
