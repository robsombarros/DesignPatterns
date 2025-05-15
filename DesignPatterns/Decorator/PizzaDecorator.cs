using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
  /// <summary>
  /// Decorator base class
  /// </summary>
  public class PizzaDecorator : IPizza
  {
    private IPizza _pizza;

    public PizzaDecorator(IPizza pizza)
    {
      _pizza = pizza;
    }
    public virtual string Opcionais()
    {
      return _pizza.Opcionais();
    }
    public virtual decimal Preco()
    {
      return _pizza.Preco();
    }
  }
}
