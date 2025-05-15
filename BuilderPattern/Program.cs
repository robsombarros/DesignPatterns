using BuilderPattern.Builders;
using BuilderPattern.Director;
using BuilderPattern.Products;

class Program
{
  static void Main()
  {
    var director = new CarDirector();

    var carBuilder = new CarBuilder();
    director.MakeSportsCar(carBuilder);
    Car car = carBuilder.GetResult();
    Console.WriteLine(car.ToString());

    var manualBuilder = new CarManualBuilder();
    director.MakeSportsCar(manualBuilder);
    Manual manual = manualBuilder.GetResult();
    Console.WriteLine(manual.ToString());

    Console.ReadLine();
  }
}
