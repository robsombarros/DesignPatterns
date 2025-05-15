using AdapterPattern.ClientInterface;
using AdapterPattern.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Adapter
{
  public class Adapter : ITarget
  {
    private Adaptee _adaptee;

    public Adapter(Adaptee adaptee)
    {
      this._adaptee = adaptee;
    }

    public string GetRequest()
    {
      // Chama o método específico do adaptee e adapta a resposta para o formato esperado pelo cliente.
      return $"This is '{_adaptee.GetSpecificRequest()}'";
    }
  }
}
