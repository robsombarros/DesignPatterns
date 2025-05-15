// O Subsistema pode aceitar solicitações diretamente do Facade ou do cliente.
// Em qualquer caso, para o Subsistema, o Facade é apenas mais um cliente e
// não faz parte do Subsistema.
using FacadePattern.Facade;

public class Subsystem1
{
  public string operation1()
  {
    return "Subsystem1: Prepare()\n";
  }

  public string operationN()
  {
    return "Subsystem1: Save()\n";
  }
}

// Alguns facades podem trabalhar com vários subsistemas ao mesmo tempo.
public class Subsystem2
{
  public string operation1()
  {
    return "Subsystem2: Prepare()\n";
  }

  public string operationZ()
  {
    return "Subsystem2: Save()\n";
  }
}


class Client
{
  // O código do cliente trabalha com subsistemas complexos por meio de uma
  // interface simples fornecida pelo Facade. Quando um Facade gerencia o ciclo
  // de vida do subsistema, o cliente pode nem saber da existência do subsistema.
  // Essa abordagem permite manter a complexidade sob controle.
  public static void ClientCode(Facade facade)
  {
    Console.Write(facade.Operation());
  }
}

class Program
{
  static void Main(string[] args)
  {
    Facade facade = new Facade();
    Console.Write(facade.Operation());

    Console.ReadLine();
  }
}