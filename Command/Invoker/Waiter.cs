using CommandPattern.Commands;

namespace CommandPattern.Invoker
{
  public class Waiter
  {
    private ICommand _command;

    public void SetCommand(ICommand command)
    {
      _command = command;
    }

    public void SendOrder()
    {
      Console.WriteLine("Garçom está enviando o pedido para a cozinha...");
      _command.Execute();
    }
  }
}
