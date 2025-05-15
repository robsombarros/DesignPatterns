namespace BuilderPattern.Builders
{
  public interface IBuilder
  {
    void Reset();
    void SetSeats(int number);
    void SetEngine(string engine);
    void SetTripComputer();
    void SetGPS();
  }
}
