using Command.Commands;
using Command.Invoker;
using Command.Receivers;

var service = new OrderService();
var processor = new CommandProcessor();

processor.AddCommand(new PlaceOrderCommand(service, "Laptop"));
processor.AddCommand(new SendConfirmationCommand(service, "Laptop"));

processor.AddCommand(new PlaceOrderCommand(service, "Phone"));
processor.AddCommand(new SendConfirmationCommand(service, "Phone"));

processor.Process();

Console.WriteLine("Undoing all operations...");
processor.UndoAll();
