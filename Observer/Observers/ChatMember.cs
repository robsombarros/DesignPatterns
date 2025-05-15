using ChatObserverPattern.Interfaces;

namespace ChatObserverPattern.Observers
{
  public class ChatMember : IChatMember
  {
    public string Name { get; }

    public ChatMember(string name)
    {
      Name = name;
    }

    public void Update(string message, string sender)
    {
      if (sender != Name)
      {
        Console.WriteLine($"[{Name}] recebeu mensagem de [{sender}]: {message}");
      }
    }
  }
}
