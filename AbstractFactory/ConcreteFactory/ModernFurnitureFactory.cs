using AbstractFactory.AbstractProduct;
using AbstractFactory.ConcreteProduct;
using AbstractFactory.Interfaces;

namespace AbstractFactory.ConcreteFactory
{
  public class ModernFurnitureFactory : IFurnitureFactory
  {
    public IChair CreateChair() => new ModernChair();
    public ISofa CreateSofa() => new ModernSofa();
  }
}
