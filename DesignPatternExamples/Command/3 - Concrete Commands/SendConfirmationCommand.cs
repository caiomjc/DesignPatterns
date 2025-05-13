using Command.Interfaces;
using Command.Receivers;

namespace Command.Commands
{
    public class SendConfirmationCommand(OrderService service, string product) : ICommand
    {
        private readonly OrderService _service = service;
        private readonly string _product = product;

        public void Execute() => _service.SendConfirmation(_product);
        public void Undo() => Console.WriteLine($"Undo: Delete confirmation record for {_product}");
    }
}
