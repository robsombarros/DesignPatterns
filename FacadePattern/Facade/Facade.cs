namespace FacadePattern.Facade
{
  // A classe Facade fornece uma interface simples para a lógica complexa de um
  // ou vários subsistemas. O Facade delega as solicitações do cliente para os
  // objetos apropriados dentro do subsistema. O Facade também é responsável
  // por gerenciar o ciclo de vida deles. Tudo isso protege o cliente da
  // complexidade indesejada do subsistema.
  public class Facade
  {
    private Subsystem1 _subsystem1;
    private Subsystem2 _subsystem2;

    public Facade()
    {
      this._subsystem1 = new Subsystem1();
      this._subsystem2 = new Subsystem2();
    }

    public string Operation()
    {
      string result = "Facade inicializa os subsistemas:\n";
      result += this._subsystem1.operation1();
      result += this._subsystem2.operation1();
      result += "Facade executando as ações dos subsistemas:\n";
      result += this._subsystem1.operationN();
      result += this._subsystem2.operationZ();
      return result;
    }
  }
}
