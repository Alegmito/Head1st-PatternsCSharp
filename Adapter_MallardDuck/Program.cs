// See https://aka.ms/new-console-template for more information
using Strategy_MallardDuck.Ducks;

Console.WriteLine("Hello, World!");

Duck mallard = new MallardDuck();
Duck rubber = new RubberDuck();

mallard.Display();

rubber.Display();