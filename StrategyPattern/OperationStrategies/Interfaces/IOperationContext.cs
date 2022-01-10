namespace StrategyPattern.OperationStrategies.Interfaces
{
    public interface IOperationContext
    {
        void SetStrategy(IOperationStrategy strategy);
        int ExecuteStrategy(int firstNumber, int secondNumber);
    }
}
