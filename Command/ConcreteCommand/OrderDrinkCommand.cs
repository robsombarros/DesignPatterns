using CommandPattern.Receiver;

namespace CommandPattern.Commands
{
  public class OrderDrinkCommand : ICommand
  {
    private readonly IChef _chef;
    private readonly string _drink;

    public OrderDrinkCommand(IChef chef, string drink)
    {
      _chef = chef;
      _drink = drink;
    }

    public void Execute()
    {
      _chef.PrepareDrink(_drink);
    }
  }
}
