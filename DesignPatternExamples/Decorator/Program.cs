// See https://aka.ms/new-console-template for more information
using Decorator.Core;
using Decorator.Decorators;

Console.WriteLine("Decorator pattern example!");

ICoffee myOrder = new SimpleCoffee();
Console.WriteLine($"{myOrder.GetDescription()} - ${myOrder.GetCost()}");

myOrder = new MilkDecorator(myOrder);
Console.WriteLine($"{myOrder.GetDescription()} - ${myOrder.GetCost()}");

myOrder = new SugarDecorator(myOrder);
Console.WriteLine($"{myOrder.GetDescription()} - ${myOrder.GetCost()}");
