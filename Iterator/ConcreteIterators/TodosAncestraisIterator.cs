using GenealogiaIterator.Interfaces;
using GenealogiaIterator.Models;

namespace GenealogiaIterator.Iterators
{
  public class TodosAncestraisIterator : IIterator<Pessoa>
  {
    private readonly Stack<Pessoa> _pilha;
    private readonly HashSet<string> _visitados;

    public TodosAncestraisIterator(Pessoa pessoaInicial)
    {
      _pilha = new Stack<Pessoa>();
      _visitados = new HashSet<string>();
      _pilha.Push(pessoaInicial);
    }

    public Pessoa GetNext()
    {
      var atual = _pilha.Pop();
      _visitados.Add(atual.Nome);

      foreach (var ancestral in atual.GetAncestrais())
      {
        if (!_visitados.Contains(ancestral.Nome))
          _pilha.Push(ancestral);
      }

      return atual;
    }

    public bool HasMore()
    {
      return _pilha.Count > 0;
    }
  }
}
