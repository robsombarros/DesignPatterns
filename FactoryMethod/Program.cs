using FactoryMethodLogistics.Creators;

class Program
{
  static void Main(string[] args)
  {
    Logistics road = new RoadLogistics();
    road.PlanDelivery();

    Logistics sea = new SeaLogistics();
    sea.PlanDelivery();

    Console.ReadLine();
  }
}