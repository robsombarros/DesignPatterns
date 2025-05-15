using AbstractFactory.AbstractProduct;

namespace AbstractFactory.ConcreteProduct
{
  public class VictorianChair : IChair
  {
    public void HasLegs() => Console.WriteLine("Cadeira Vitoriana: Possui pernas de madeira curvas.");
    public void SitOn() => Console.WriteLine("Cadeira Vitoriana: Sentando elegantemente.");
  }
}
