using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ConcreteComponent
{
  internal class Pizza : IPizza
  {
    public string Opcionais()
    {
      return "Pizza padrão ou normal";
    }

    public decimal Preco()
    {
      return 10.00M;
    }
  }
}
