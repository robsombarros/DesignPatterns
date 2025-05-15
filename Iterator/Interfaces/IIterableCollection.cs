using GenealogiaIterator.Collections;

namespace GenealogiaIterator.Interfaces
{
  public interface IIterableCollection<T>
  {
    IIterator<T> CreateIterator(TipoIterator tipo);
  }
}
