namespace CommandPattern.Receiver
{
  public class Chef : IChef
  {
    public void PreparePizza(string type)
    {
      Console.WriteLine($"Cozinheiro está preparando a pizza: {type}");
    }

    public void PrepareDrink(string drink)
    {
      Console.WriteLine($"Cozinheiro está preparando a bebida: {drink}");
    }
  }
}
