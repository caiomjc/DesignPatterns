using Command.Interfaces;
using Command.Receivers;

namespace Command.Commands
{
    public class PlaceOrderCommand(OrderService service, string product) : ICommand
    {
        private readonly OrderService _service = service;
        private readonly string _product = product;

        public void Execute() => _service.PlaceOrder(_product);
        public void Undo() => _service.CancelOrder(_product);
    }
}
