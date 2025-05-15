using BuilderPattern.Products;

namespace BuilderPattern.Builders
{
  public class CarManualBuilder : IBuilder
  {
    private Manual manual = new Manual();

    public CarManualBuilder()
    {
      Reset();
    }

    public void Reset()
    {
      manual = new Manual();
    }

    public void SetSeats(int number)
    {
      manual.Seats = number;
    }

    public void SetEngine(string engine)
    {
      manual.Engine = engine;
    }

    public void SetTripComputer()
    {
      manual.HasTripComputer = true;
    }

    public void SetGPS()
    {
      manual.HasGPS = true;
    }

    public Manual GetResult()
    {
      return manual;
    }
  }
}
