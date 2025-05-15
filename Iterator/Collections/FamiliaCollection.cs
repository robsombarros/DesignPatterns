using GenealogiaIterator.Interfaces;
using GenealogiaIterator.Iterators;
using GenealogiaIterator.Models;

namespace GenealogiaIterator.Collections
{
  public enum TipoIterator
  {
    TodosAncestrais,
    AscendenteDiretoPai
  }

  public class FamiliaCollection : IIterableCollection<Pessoa>
  {
    private readonly Pessoa _pessoaRaiz;

    public FamiliaCollection(Pessoa pessoaRaiz)
    {
      _pessoaRaiz = pessoaRaiz;
    }

    public IIterator<Pessoa> CreateIterator(TipoIterator tipo)
    {
      return tipo switch
      {
        TipoIterator.TodosAncestrais => new TodosAncestraisIterator(_pessoaRaiz),
        TipoIterator.AscendenteDiretoPai => new AscendenteDiretoIterator(_pessoaRaiz),
        _ => throw new NotImplementedException()
      };
    }
  }
}
