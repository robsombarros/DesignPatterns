using AbstractFactory.AbstractProduct;

namespace AbstractFactory.Interfaces
{
  public interface IFurnitureFactory
  {
    IChair CreateChair();
    ISofa CreateSofa();
  }

}
