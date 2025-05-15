using FlyWeightPattern.FlyWeight;

namespace FlyWeightPattern.FlyWeightFactory
{
  public class ParticleFactory
  {
    private readonly Dictionary<string, Particle> _particles = new();

    public Particle GetParticle(string color, string sprite)
    {
      string key = $"{color}:{sprite}";

      if (!_particles.ContainsKey(key))
        _particles[key] = new Particle(color, sprite);

      return _particles[key];
    }
  }
}
