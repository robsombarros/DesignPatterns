namespace BuilderPattern.Products
{
  public class Manual
  {
    public int Seats { get; set; }
    public string Engine { get; set; }
    public bool HasTripComputer { get; set; }
    public bool HasGPS { get; set; }

    public override string ToString()
    {
      return $"Manual: {Seats} assentos, motor {Engine}, " +
             $"instrução do computador de viagem: {(HasTripComputer ? "sim" : "não")}, GPS: {(HasGPS ? "sim" : "não")}";
    }
  }
}
