//Cliente faz pedidos (ex: pedir pizza, pedir bebida).
//O garçom (Invoker) executa o pedido.
//O pedido é um comando que envolve o Cozinheiro (Receiver).
using CommandPattern.Commands;
using CommandPattern.Invoker;
using CommandPattern.Receiver;

namespace CommandPattern.Client
{
  class Program
  {
    static void Main(string[] args)
    {
      IChef chef = new Chef();
      Waiter waiter = new Waiter();

      ICommand pizzaOrder = new OrderPizzaCommand(chef, "Calabresa");
      ICommand drinkOrder = new OrderDrinkCommand(chef, "Suco de Laranja");

      waiter.SetCommand(pizzaOrder);
      waiter.SendOrder();
      Console.WriteLine();

      waiter.SetCommand(drinkOrder);
      waiter.SendOrder();

      Console.WriteLine("Pressione qualquer tecla para sair...");
      Console.ReadLine();
    }
  }
}
