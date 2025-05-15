using GenealogiaIterator.Interfaces;
using GenealogiaIterator.Models;

namespace GenealogiaIterator.Iterators
{
  public class AscendenteDiretoIterator : IIterator<Pessoa>
  {
    private Pessoa? _atual;

    public AscendenteDiretoIterator(Pessoa pessoaInicial)
    {
      _atual = pessoaInicial;
    }

    public Pessoa GetNext()
    {
      var atual = _atual;
      _atual = _atual?.Pai;
      return atual!;
    }

    public bool HasMore()
    {
      return _atual != null;
    }
  }
}
