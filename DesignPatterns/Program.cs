using Decorator.Component;
using Decorator.ConcreteComponent;
using Decorator.ConcreteDecorator;
using Decorator.Decorator;

IPizza pizza = new Pizza();

Console.WriteLine(pizza.Opcionais());
Console.WriteLine($"Preço R$ {pizza.Preco()}");
Console.WriteLine("Tecle algo para aplicar o padrão Decorator");
Console.ReadLine();

Console.WriteLine(" --------------- Aplicando o padrão Decorator -------------");

IPizza pizza2 = new Pizza();
IPizza massaEspecial = new MassaEspecialDecorator(pizza2);
IPizza baconDecorator = new BaconDecorator(massaEspecial);
IPizza bordaDecorator = new BordaRecheadaDecorator(baconDecorator);

Console.WriteLine(bordaDecorator.Opcionais());
Console.WriteLine($"Preço R$ {bordaDecorator.Preco()}");
Console.ReadLine();
