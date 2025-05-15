using FlyWeightPattern.FlyWeight;

namespace FlyWeightPattern.Context
{
  public class MovingParticle
  {
    public Particle Particle { get; }
    public string Coords { get; set; }
    public string Vector { get; }
    public float Speed { get; }

    public void Move()
    {
      // Simula movimento
      Coords = $"{Coords}+{Vector}";
    }

    public void Draw(string canvas)
    {
      Particle.Draw(Coords, canvas);
    }

    public MovingParticle(Particle particle, string coords, string vector, float speed)
    {
      Particle = particle;
      Coords = coords;
      Vector = vector;
      Speed = speed;
    }
  }
}
