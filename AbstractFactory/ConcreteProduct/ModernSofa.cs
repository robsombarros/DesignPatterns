using AbstractFactory.AbstractProduct;

namespace AbstractFactory.ConcreteProduct
{
  public class ModernSofa : ISofa
  {
    public void LieOn() => Console.WriteLine("Sofá Moderno: Deitando confortavelmente.");
  }
}
