namespace FlyWeightPattern.FlyWeight
{
  public class Particle
  {
    public string Color { get; }
    public string Sprite { get; }

    public Particle(string color, string sprite)
    {
      Color = color;
      Sprite = sprite;
    }

    public void Draw(string coords, string canvas)
    {
      Console.WriteLine($"Drawing particle at {coords} on {canvas} with color {Color} and sprite {Sprite}");
    }
  }
}
