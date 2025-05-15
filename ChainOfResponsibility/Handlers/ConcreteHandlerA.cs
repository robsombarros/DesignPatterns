using System;

namespace ChainOfResponsibility.Handlers
{
  public class ConcreteHandlerA : BaseHandler
  {
    public override void Handle(string request)
    {
      if (request == "A")
      {
        Console.WriteLine("ConcreteHandlerA processou a requisição.");
      }
      else
      {
        base.Handle(request);
      }
    }
  }
}
