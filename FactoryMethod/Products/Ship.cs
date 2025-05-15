using FactoryMethodLogistics.Interfaces;

namespace FactoryMethodLogistics.Products
{
  public class Ship : ITransport
  {
    public void Deliver()
    {
      Console.WriteLine("Entrega por mar em um contêiner.");
    }
  }
}