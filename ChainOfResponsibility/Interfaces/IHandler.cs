namespace ChainOfResponsibility.Handlers
{
  public interface IHandler
  {
    IHandler SetNext(IHandler handler);
    void Handle(string request);
  }
}
