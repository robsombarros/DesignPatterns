using AbstractFactory.AbstractProduct;
using AbstractFactory.ConcreteProduct;
using AbstractFactory.Interfaces;

namespace AbstractFactory.ConcreteFactory
{
  public class VictorianFurnitureFactory : IFurnitureFactory
  {
    public IChair CreateChair() => new VictorianChair();
    public ISofa CreateSofa() => new VictorianSofa();
  }
}
