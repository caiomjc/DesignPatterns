using StrategyPattern.OperationStrategies;
using StrategyPattern.OperationStrategies.Strategies;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strategy Pattern");

            var firstNumber = 9;
            var secondNumber = 3;

            Calculate((int)OperationEnum.Add, firstNumber, secondNumber);
            Calculate((int)OperationEnum.Subtract, firstNumber, secondNumber);
            Calculate((int)OperationEnum.Multiply, firstNumber, secondNumber);
            Calculate((int)OperationEnum.Divide, firstNumber, secondNumber);
        }

        static void Calculate(int operation, int firstNumber, int secondNumber)
        {
            var operationContext = new OperationContext();

            switch (operation)
            {
                case (int)OperationEnum.Add:
                    operationContext.SetStrategy(new AddStrategy());
                    break;
                case (int)OperationEnum.Subtract:
                    operationContext.SetStrategy(new SubtractStrategy());
                    break;
                case (int)OperationEnum.Multiply:
                    operationContext.SetStrategy(new MultiplyStrategy());
                    break;
                case (int)OperationEnum.Divide:
                    operationContext.SetStrategy(new DivideStrategy());
                    break;
            }

            var result = operationContext.ExecuteStrategy(firstNumber, secondNumber);

            Console.WriteLine($"The result of the operation is {result}.");
        }
    }
}
