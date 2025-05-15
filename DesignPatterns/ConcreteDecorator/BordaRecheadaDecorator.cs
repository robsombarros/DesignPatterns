using Decorator.Component;
using Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteDecorator
{
  public class BordaRecheadaDecorator : PizzaDecorator
  {
    public BordaRecheadaDecorator(IPizza pizza) : base(pizza)
    {
    }
    public override string Opcionais()
    {
      return base.Opcionais() + "\r\n com borda recheada";
    }
    public override decimal Preco()
    {
      return base.Preco() + 5.00M;
    }
  }
}
