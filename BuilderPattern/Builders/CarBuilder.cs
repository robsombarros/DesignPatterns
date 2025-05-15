using BuilderPattern.Products;

namespace BuilderPattern.Builders
{
  public class CarBuilder : IBuilder
  {
    private Car car = new Car();

    public CarBuilder()
    {
      Reset();
    }

    public void Reset()
    {
      car = new Car();
    }

    public void SetSeats(int number)
    {
      car.Seats = number;
    }

    public void SetEngine(string engine)
    {
      car.Engine = engine;
    }

    public void SetTripComputer()
    {
      car.HasTripComputer = true;
    }

    public void SetGPS()
    {
      car.HasGPS = true;
    }

    public Car GetResult()
    {
      return car;
    }
  }
}
