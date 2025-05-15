using FactoryMethodLogistics.Interfaces;

namespace FactoryMethodLogistics.Products
{
  public class Truck : ITransport
  {
    public void Deliver()
    {
      Console.WriteLine("Entrega por terra em uma caixa.");
    }
  }
}
