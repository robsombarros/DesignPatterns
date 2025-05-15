using AbstractFactory.AbstractProduct;

namespace AbstractFactory.ConcreteProduct
{
  public class ModernChair : IChair
  {
    public void HasLegs() => Console.WriteLine("Cadeira Moderna: Pernas de metal elegantes.");
    public void SitOn() => Console.WriteLine("Cadeira Moderna: Sentando com minimalismo.");
  }
}
