using BuilderPattern.Builders;

namespace BuilderPattern.Director
{
  public class CarDirector
  {
    public void MakeSportsCar(IBuilder builder)
    {
      builder.Reset();
      builder.SetSeats(2);
      builder.SetEngine("Motor Esportivo");
      builder.SetTripComputer();
      builder.SetGPS();
    }

    public void MakeSUV(IBuilder builder)
    {
      builder.Reset();
      builder.SetSeats(7);
      builder.SetEngine("Motor V6");
      builder.SetGPS();
    }
  }
}
