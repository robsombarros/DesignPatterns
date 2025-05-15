using System;

namespace ChainOfResponsibility.Handlers
{
  public abstract class BaseHandler : IHandler
  {
    private IHandler _next;

    public IHandler SetNext(IHandler handler)
    {
      _next = handler;
      return handler;
    }

    public virtual void Handle(string request)
    {
      if (_next != null)
      {
        _next.Handle(request);
      }
      else
      {
        Console.WriteLine("Nenhum handler pôde processar a requisição.");
      }
    }
  }
}
