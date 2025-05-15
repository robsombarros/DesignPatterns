using System;

namespace ChainOfResponsibility.Handlers
{
  public class ConcreteHandlerC : BaseHandler
  {
    public override void Handle(string request)
    {
      if (request == "C")
      {
        Console.WriteLine("ConcreteHandlerC processou a requisição.");
      }
      else
      {
        base.Handle(request);
      }
    }
  }
}
