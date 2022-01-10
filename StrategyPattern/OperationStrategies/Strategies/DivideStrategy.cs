using StrategyPattern.OperationStrategies.Interfaces;

namespace StrategyPattern.OperationStrategies.Strategies
{
    public class DivideStrategy : IOperationStrategy
    {
        public int Calculate(int firstNumber, int secondNumber)
        {
            if (secondNumber == 0)
                return 0;

            return firstNumber / secondNumber;
        }
    }
}
