using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.ClientInterface
{
  /// <summary>
  /// Define a interface específica do domínio usada pelo código do cliente.
  /// </summary>
  public interface ITarget
  {
    string GetRequest();
  }
}
