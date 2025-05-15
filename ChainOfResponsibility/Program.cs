using System;
using ChainOfResponsibility.Handlers;

namespace ChainOfResponsibility
{
  class Program
  {
    static void Main(string[] args)
    {
      var h1 = new ConcreteHandlerA();
      var h2 = new ConcreteHandlerB();
      var h3 = new ConcreteHandlerC();

      h1.SetNext(h2).SetNext(h3);
      //h3.SetNext(h2).SetNext(h1);

      string[] requests = { "A", "B", "C", "D" };

      foreach (var req in requests)
      {
        Console.WriteLine($"\nSolicitação: {req}");
        h1.Handle(req);
        //h3.Handle(req);
      }

      Console.ReadLine();
    }
  }
}
