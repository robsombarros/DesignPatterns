using FlyWeightPattern.Context;
using FlyWeightPattern.FlyWeightFactory;

namespace FlyWeightPattern
{
  public class Game
  {
    private readonly List<MovingParticle> _movingParticles = new();
    private readonly ParticleFactory _particleFactory = new();

    public void AddParticle(string coords, string vector, float speed, string color, string sprite)
    {
      var particle = _particleFactory.GetParticle(color, sprite);
      var movingParticle = new MovingParticle(particle, coords, vector, speed);
      _movingParticles.Add(movingParticle);
    }

    public void Draw(string canvas)
    {
      foreach (var mp in _movingParticles)
      {
        mp.Draw(canvas);
      }
    }
  }
}
