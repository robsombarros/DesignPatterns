using FactoryMethodLogistics.Interfaces;
using FactoryMethodLogistics.Products;

namespace FactoryMethodLogistics.Creators
{
  public class SeaLogistics : Logistics
  {
    public override ITransport CreateTransport()
    {
      return new Ship();
    }
  }
}
