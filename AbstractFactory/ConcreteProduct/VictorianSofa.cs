using AbstractFactory.AbstractProduct;

namespace AbstractFactory.ConcreteProduct
{
  public class VictorianSofa : ISofa
  {
    public void LieOn() => Console.WriteLine("Sofá Vitoriano: Deitando como realeza.");
  }
}
