using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern
{
  public class Unit
  {
    public string Coords { get; set; }

    public void FireAt(Unit target, Game game, float weaponPower)
    {
      string color = "red";
      string sprite = "bullet.jpeg";
      string vector = "→"; // Simbolicamente

      game.AddParticle(Coords, vector, weaponPower, color, sprite);
    }
  }
}
