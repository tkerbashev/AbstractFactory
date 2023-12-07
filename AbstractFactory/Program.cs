using AbstractFactory;

Console.WriteLine( "Abstract Factory Creational Design Pattern example\n" );

Console.Title = "Abstract Factory";

var morningTeaFactory = new TeaFactory();
var morningTea = new MorningRoutine(morningTeaFactory);
morningTea.Drink();

Console.WriteLine();

var morningCoffeeFactory = new CoffeeFactory();
var morningCoffee = new MorningRoutine(morningCoffeeFactory);
morningCoffee.Drink();
