using AbstractFactory.ConcreteFactory;
using AbstractFactory.Interfaces;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Escolha o estilo de mobília (1) Vitoriano ou (2) Moderno:");
    var escolha = Console.ReadLine();

    IFurnitureFactory factory = escolha == "1"
        ? new VictorianFurnitureFactory()
        : new ModernFurnitureFactory();

    var chair = factory.CreateChair();
    var sofa = factory.CreateSofa();

    Console.WriteLine("\n== Operações do Mobiliário Criado ==\n");

    chair.HasLegs();
    chair.SitOn();
    sofa.LieOn();

    Console.WriteLine("\nFim da demonstração.");

    Console.ReadLine();
  }
}
