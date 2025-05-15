using System;

namespace ChainOfResponsibility.Handlers
{
  public class ConcreteHandlerB : BaseHandler
  {
    public override void Handle(string request)
    {
      if (request == "B")
      {
        Console.WriteLine("ConcreteHandlerB processou a requisição.");
      }
      else
      {
        base.Handle(request);
      }
    }
  }
}