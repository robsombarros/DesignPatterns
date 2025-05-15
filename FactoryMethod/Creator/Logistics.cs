using FactoryMethodLogistics.Interfaces;

namespace FactoryMethodLogistics.Creators
{
  public abstract class Logistics
  {
    public void PlanDelivery()
    {
      ITransport transport = CreateTransport();
      Console.Write("Planejando entrega... ");
      transport.Deliver();
    }

    public abstract ITransport CreateTransport();
  }
}
