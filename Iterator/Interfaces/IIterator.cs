namespace GenealogiaIterator.Interfaces
{
  public interface IIterator<T>
  {
    T GetNext();
    bool HasMore();
  }
}
