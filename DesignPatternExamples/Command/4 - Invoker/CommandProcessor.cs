using Command.Interfaces;

namespace Command.Invoker
{
    public class CommandProcessor
    {
        private readonly Queue<ICommand> _queue = new();
        private readonly Stack<ICommand> _history = new();

        public void AddCommand(ICommand command)
        {
            _queue.Enqueue(command);
        }

        public void Process()
        {
            while (_queue.Any())
            {
                var command = _queue.Dequeue();
                command.Execute();
                _history.Push(command);
            }
        }

        public void UndoAll()
        {
            while (_history.Any())
            {
                var command = _history.Pop();
                command.Undo();
            }
        }
    }
}
