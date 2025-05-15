namespace BuilderPattern.Products
{
  public class Car
  {
    public int Seats { get; set; }
    public string Engine { get; set; }
    public bool HasTripComputer { get; set; }
    public bool HasGPS { get; set; }

    public override string ToString()
    {
      return $"Carro com {Seats} assentos, motor {Engine}, " +
             $"computador de viagem: {(HasTripComputer ? "sim" : "não")}, GPS: {(HasGPS ? "sim" : "não")}";
    }
  }
}
