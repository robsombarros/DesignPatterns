using FactoryMethodLogistics.Interfaces;
using FactoryMethodLogistics.Products;

namespace FactoryMethodLogistics.Creators
{
  public class RoadLogistics : Logistics
  {
    public override ITransport CreateTransport()
    {
      return new Truck();
    }
  }
}