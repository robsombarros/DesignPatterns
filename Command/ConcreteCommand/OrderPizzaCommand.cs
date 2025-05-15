using CommandPattern.Receiver;

namespace CommandPattern.Commands
{
  public class OrderPizzaCommand : ICommand
  {
    private readonly IChef _chef;
    private readonly string _pizzaType;

    public OrderPizzaCommand(IChef chef, string pizzaType)
    {
      _chef = chef;
      _pizzaType = pizzaType;
    }

    public void Execute()
    {
      _chef.PreparePizza(_pizzaType);
    }
  }
}
